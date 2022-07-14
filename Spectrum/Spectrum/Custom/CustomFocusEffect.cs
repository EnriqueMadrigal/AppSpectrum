using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Spectrum.Custom
{
    public class CustomFocusEffect :RoutingEffect
    {
        public CustomFocusEffect() : base($"MyEffect.{nameof(CustomFocusEffect)}")
        {
        }

    }
}
