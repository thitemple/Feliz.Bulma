﻿namespace Feliz.Bulma

[<RequireQualifiedAccess>]        
module Container =
    let isFluid = PropertyBuilders.mkClass "is-fluid"
    let isWidescreen = PropertyBuilders.mkClass "is-widescreen"
    let isFullHd = PropertyBuilders.mkClass "is-fullhd"

[<RequireQualifiedAccess>]        
module Level =
    let isMobile = PropertyBuilders.mkClass "is-mobile"

[<RequireQualifiedAccess>]
module Section =
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"

[<RequireQualifiedAccess>]        
module Hero =
    let isBold = PropertyBuilders.mkClass "is-bold"
    let isMedium = PropertyBuilders.mkClass "is-medium"
    let isLarge = PropertyBuilders.mkClass "is-large"
    let isFullHeight = PropertyBuilders.mkClass "is-fullheight"
    let isFullHeightWithNavbar = PropertyBuilders.mkClass "is-fullheight-with-navbar"

[<RequireQualifiedAccess>]        
module Tile =
    let isAncestor = PropertyBuilders.mkClass "is-ancestor"
    let isParent = PropertyBuilders.mkClass "is-parent"
    let isChild = PropertyBuilders.mkClass "is-child"
    let isVertical = PropertyBuilders.mkClass "is-vertical"
    let is1 = PropertyBuilders.mkClass "is-1"
    let is2 = PropertyBuilders.mkClass "is-2"
    let is3 = PropertyBuilders.mkClass "is-3"
    let is4 = PropertyBuilders.mkClass "is-4"
    let is5 = PropertyBuilders.mkClass "is-5"
    let is6 = PropertyBuilders.mkClass "is-6"
    let is7 = PropertyBuilders.mkClass "is-7"
    let is8 = PropertyBuilders.mkClass "is-8"
    let is9 = PropertyBuilders.mkClass "is-9"
    let is10 = PropertyBuilders.mkClass "is-10"
    let is11 = PropertyBuilders.mkClass "is-11"
    let is12 = PropertyBuilders.mkClass "is-12"

[<RequireQualifiedAccess>]        
module Column =
    let isMobile = PropertyBuilders.mkClass "is-mobile"
    let isDesktop = PropertyBuilders.mkClass "is-desktop"
    
    let is1 = PropertyBuilders.mkClass "is-1"
    let is2 = PropertyBuilders.mkClass "is-2"
    let is3 = PropertyBuilders.mkClass "is-3"
    let is4 = PropertyBuilders.mkClass "is-4"
    let is5 = PropertyBuilders.mkClass "is-5"
    let is6 = PropertyBuilders.mkClass "is-6"
    let is7 = PropertyBuilders.mkClass "is-7"
    let is8 = PropertyBuilders.mkClass "is-8"
    let is9 = PropertyBuilders.mkClass "is-9"
    let is10 = PropertyBuilders.mkClass "is-10"
    let is11 = PropertyBuilders.mkClass "is-11"
    let is12 = PropertyBuilders.mkClass "is-12"
    
    let isThreeQuarters = PropertyBuilders.mkClass "is-three-quarters"
    let isTwoThirds = PropertyBuilders.mkClass "is-two-thirds"
    let isHalf = PropertyBuilders.mkClass "is-half"
    let isOneThird = PropertyBuilders.mkClass "is-one-third"
    let isOneQuarter = PropertyBuilders.mkClass "is-one-quarter"
    let isFull = PropertyBuilders.mkClass "is-full"
    let isFourFifths = PropertyBuilders.mkClass "is-four-fifths"
    let isThreeFifths = PropertyBuilders.mkClass "is-three-fifths"
    let isTwoFifths = PropertyBuilders.mkClass "is-two-fifths"
    let isOneFifth = PropertyBuilders.mkClass "is-one-fifth"
    let isNarrowMobile = PropertyBuilders.mkClass "is-narrow-mobile"
    let isNarrowTablet = PropertyBuilders.mkClass "is-narrow-tablet"
    let isNarrowTouch = PropertyBuilders.mkClass "is-narrow-touch"
    let isNarrowDesktop = PropertyBuilders.mkClass "is-narrow-desktop"
    let isNarrowWidescreen = PropertyBuilders.mkClass "is-narrow-widescreen"
    let isNarrowFullhd = PropertyBuilders.mkClass "is-narrow-fullhd"
    
    let isOffset1 = PropertyBuilders.mkClass "is-offset-1"
    let isOffset2 = PropertyBuilders.mkClass "is-offset-2"
    let isOffset3 = PropertyBuilders.mkClass "is-offset-3"
    let isOffset4 = PropertyBuilders.mkClass "is-offset-4"
    let isOffset5 = PropertyBuilders.mkClass "is-offset-5"
    let isOffset6 = PropertyBuilders.mkClass "is-offset-6"
    let isOffset7 = PropertyBuilders.mkClass "is-offset-7"
    let isOffset8 = PropertyBuilders.mkClass "is-offset-8"
    let isOffset9 = PropertyBuilders.mkClass "is-offset-9"
    let isOffset10 = PropertyBuilders.mkClass "is-offset-10"
    let isOffset11 = PropertyBuilders.mkClass "is-offset-11"
    let isOffset12 = PropertyBuilders.mkClass "is-offset-12"
    let isOffsetThreeQuarters = PropertyBuilders.mkClass "is-offset-three-quarters"
    let isOffsetTwoThirds = PropertyBuilders.mkClass "is-offset-two-thirds"
    let isOffsetHalf = PropertyBuilders.mkClass "is-offset-half"
    let isOffsetOneThird = PropertyBuilders.mkClass "is-offset-one-third"
    let isOffsetOneQuarter = PropertyBuilders.mkClass "is-offset-one-quarter"
    let isOffsetFull = PropertyBuilders.mkClass "is-offset-full"
    let isOffsetFourFifths = PropertyBuilders.mkClass "is-offset-four-fifths"
    let isOffsetThreeFifths = PropertyBuilders.mkClass "is-offset-three-fifths"
    let isOffsetTwoFifths = PropertyBuilders.mkClass "is-offset-two-fifths"
    let isOffsetOneFifth = PropertyBuilders.mkClass "is-offset-one-fifth"
    
    let isThreeQuartersMobile = PropertyBuilders.mkClass "is-three-quarters-mobile"
    let isTwoThirdsMobile = PropertyBuilders.mkClass "is-two-thirds-mobile"
    let isHalfMobile = PropertyBuilders.mkClass "is-half-mobile"
    let isOneThirdMobile = PropertyBuilders.mkClass "is-one-third-mobile"
    let isOneQuarterMobile = PropertyBuilders.mkClass "is-one-quarter-mobile"
    let isFullMobile = PropertyBuilders.mkClass "is-full-mobile"
    let isFourFifthsMobile = PropertyBuilders.mkClass "is-four-fifths-mobile"
    let isThreeFifthsMobile = PropertyBuilders.mkClass "is-three-fifths-mobile"
    let isTwoFifthsMobile = PropertyBuilders.mkClass "is-two-fifths-mobile"
    let isOneFifthMobile = PropertyBuilders.mkClass "is-one-fifth-mobile"
    let isThreeQuartersTablet = PropertyBuilders.mkClass "is-three-quarters-tablet"
    let isTwoThirdsTablet = PropertyBuilders.mkClass "is-two-thirds-tablet"
    let isHalfTablet = PropertyBuilders.mkClass "is-half-tablet"
    let isOneThirdTablet = PropertyBuilders.mkClass "is-one-third-tablet"
    let isOneQuarterTablet = PropertyBuilders.mkClass "is-one-quarter-tablet"
    let isFullTablet = PropertyBuilders.mkClass "is-full-tablet"
    let isFourFifthsTablet = PropertyBuilders.mkClass "is-four-fifths-tablet"
    let isThreeFifthsTablet = PropertyBuilders.mkClass "is-three-fifths-tablet"
    let isTwoFifthsTablet = PropertyBuilders.mkClass "is-two-fifths-tablet"
    let isOneFifthTablet = PropertyBuilders.mkClass "is-one-fifth-tablet"
    let isThreeQuartersDesktop = PropertyBuilders.mkClass "is-three-quarters-desktop"
    let isTwoThirdsDesktop = PropertyBuilders.mkClass "is-two-thirds-desktop"
    let isHalfDesktop = PropertyBuilders.mkClass "is-half-desktop"
    let isOneThirdDesktop = PropertyBuilders.mkClass "is-one-third-desktop"
    let isOneQuarterDesktop = PropertyBuilders.mkClass "is-one-quarter-desktop"
    let isFullDesktop = PropertyBuilders.mkClass "is-full-desktop"
    let isFourFifthsDesktop = PropertyBuilders.mkClass "is-four-fifths-desktop"
    let isThreeFifthsDesktop = PropertyBuilders.mkClass "is-three-fifths-desktop"
    let isTwoFifthsDesktop = PropertyBuilders.mkClass "is-two-fifths-desktop"
    let isOneFifthDesktop = PropertyBuilders.mkClass "is-one-fifth-desktop"
    let isThreeQuartersWideScreen = PropertyBuilders.mkClass "is-three-quarters-widescreen"
    let isTwoThirdsWideScreen = PropertyBuilders.mkClass "is-two-thirds-widescreen"
    let isHalfWideScreen = PropertyBuilders.mkClass "is-half-widescreen"
    let isOneThirdWideScreen = PropertyBuilders.mkClass "is-one-third-widescreen"
    let isOneQuarterWideScreen = PropertyBuilders.mkClass "is-one-quarter-widescreen"
    let isFullWideScreen = PropertyBuilders.mkClass "is-full-widescreen"
    let isFourFifthsWideScreen = PropertyBuilders.mkClass "is-four-fifths-widescreen"
    let isThreeFifthsWideScreen = PropertyBuilders.mkClass "is-three-fifths-widescreen"
    let isTwoFifthsWideScreen = PropertyBuilders.mkClass "is-two-fifths-widescreen"
    let isOneFifthWideScreen = PropertyBuilders.mkClass "is-one-fifth-widescreen"
    let isThreeQuartersFullHd = PropertyBuilders.mkClass "is-three-quarters-fullhd"
    let isTwoThirdsFullHd = PropertyBuilders.mkClass "is-two-thirds-fullhd"
    let isHalfFullHd = PropertyBuilders.mkClass "is-half-fullhd"
    let isOneThirdFullHd = PropertyBuilders.mkClass "is-one-third-fullhd"
    let isOneQuarterFullHd = PropertyBuilders.mkClass "is-one-quarter-fullhd"
    let isFullFullHd = PropertyBuilders.mkClass "is-full-fullhd"
    let isFourFifthsFullHd = PropertyBuilders.mkClass "is-four-fifths-fullhd"
    let isThreeFifthsFullHd = PropertyBuilders.mkClass "is-three-fifths-fullhd"
    let isTwoFifthsFullHd = PropertyBuilders.mkClass "is-two-fifths-fullhd"
    let isOneFifthFullHd = PropertyBuilders.mkClass "is-one-fifth-fullhd"
    
    let isGapless = PropertyBuilders.mkClass "is-gapless"
    let isMultiline = PropertyBuilders.mkClass "is-multiline"
    let isVariable = PropertyBuilders.mkClass "is-variable"
    let isCentered = PropertyBuilders.mkClass "is-centered"
    let isVcentered = PropertyBuilders.mkClass "is-vcentered"    