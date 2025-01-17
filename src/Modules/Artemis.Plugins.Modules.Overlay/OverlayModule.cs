﻿using Artemis.Core;
using Artemis.Core.Modules;
using SkiaSharp;

namespace Artemis.Plugins.Modules.Overlay
{
    [PluginFeature(AlwaysEnabled = true)]
    public class OverlayModule : ProfileModule
    {
        // This is the beginning of your plugin life cycle. Use this instead of a constructor.
        public override void Enable()
        {
            DisplayName = "Overlay";
            DisplayIcon = "ArrangeBringToFront";
            DefaultPriorityCategory = ModulePriorityCategory.Overlay;
        }

        // This is the end of your plugin life cycle.
        public override void Disable()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override void ModuleActivated(bool isOverride)
        {
            // When this gets called your activation requirements have been met and the module will start displaying
        }

        public override void ModuleDeactivated(bool isOverride)
        {
            // When this gets called your activation requirements are no longer met and your module will stop displaying
        }

        public override void Update(double deltaTime)
        {
        }

        public override void Render(double deltaTime, SKCanvas canvas, SKImageInfo canvasInfo)
        {
        }
    }
}