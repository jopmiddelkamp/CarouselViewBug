﻿using CarouselView.FormsPlugin.Abstractions;

namespace BugReproduction.Controls
{
    public class CarouselView : CarouselViewControl
    {
        public CarouselView()
        {
            Orientation = CarouselViewOrientation.Horizontal;

            ShowIndicators = true;

            // This causes the app to crash!
            //ShowArrows = true;

            InterPageSpacing = 20;
        }
    }
}
