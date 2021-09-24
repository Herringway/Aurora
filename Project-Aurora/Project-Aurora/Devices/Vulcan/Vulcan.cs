﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.Settings;
using Aurora.Utils;
using Vulcan.NET;

namespace Aurora.Devices.Vulcan
{
    public class VulcanDevice : DefaultDevice
    {
        public override string DeviceName => "Vulcan";

        protected override string DeviceInfo => string.Join(",", _keyboards.Select(kb => kb.KeyboardType));

        private List<IVulcanKeyboard> _keyboards;

        public override bool Initialize()
        {
            _keyboards = VulcanFinder.FindKeyboards().ToList();

            return IsInitialized = _keyboards.Count > 0;
        }

        public override void Shutdown()
        {
            foreach (var keyboard in _keyboards)
            {
                keyboard.Dispose();
            }

            _keyboards.Clear();
        }

        public override bool UpdateDevice(Dictionary<DeviceKeys, Color> keyColors, DoWorkEventArgs e, bool forced = false)
        {
            if (!IsInitialized)
                return false;

            foreach (var key in keyColors)
            {
                foreach (var keyboard in _keyboards)
                {
                    if (VulcanKeyMap.KeyMap.TryGetValue(key.Key, out var vulcanKey))
                    {
                        var color = ColorUtils.CorrectWithAlpha(key.Value);
                        keyboard.SetKeyColor(vulcanKey,color.R, color.G, color.B );
                    }
                }
            }
            foreach (var keyboard in _keyboards)
            {
                keyboard.Update();
            }

            return true;
        }
    }
}
