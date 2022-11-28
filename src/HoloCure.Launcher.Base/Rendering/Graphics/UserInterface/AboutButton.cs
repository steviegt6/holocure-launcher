﻿// Copyright (c) Tomat. Licensed under the GPL v3 License.
// See the LICENSE-GPL file in the repository root for full license text.

using System;
using HoloCure.Launcher.Base.Rendering.Graphics.Containers;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Input.Events;
using osu.Framework.Localisation;
using osuTK;

namespace HoloCure.Launcher.Base.Rendering.Graphics.UserInterface;

public class AboutButton : LauncherClickableContainer
{
    public override LocalisableString TooltipText
    {
        get => "About HoloCure.Launcher";
        set => throw new InvalidOperationException("Cannot set TooltipText of AboutButton.");
    }

    [BackgroundDependencyLoader]
    private void load(TextureStore textures, LauncherTheme theme)
    {
        Masking = true;
        CornerRadius = 10f;

        InternalChildren = new Drawable[]
        {
            new Box
            {
                RelativeSizeAxes = Axes.Both,

                // Made to blend in with LauncherOverlay background, as that's what this is for
                Colour = theme.BackgroundColour,

                Origin = Anchor.Centre,
                Anchor = Anchor.Centre,

                // Small scaling for a border (essentially emulates padding)
                Scale = new Vector2(1.1f)
            },

            new SpriteIcon
            {
                RelativeSizeAxes = Axes.Both,

                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,

                Icon = FontAwesome.Solid.Rocket,

                Colour = theme.LogoPinkColor,

                Scale = new Vector2(0.75f)
            }
        };
    }

    protected override bool OnHover(HoverEvent e)
    {
        this.ScaleTo(1.2f, 250D, Easing.OutExpo);

        return base.OnHover(e);
    }

    protected override void OnHoverLost(HoverLostEvent e)
    {
        this.ScaleTo(1f, 250D, Easing.OutExpo);

        base.OnHoverLost(e);
    }
}