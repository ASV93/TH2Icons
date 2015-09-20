//============================================================================
//
//    TH2Icons
//    Copyright (C) 2015 Visual Software Corporation
//
//    Author: ASV93
//    File: ImmersiveColors.cs
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
//============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCORP.TH2Icons.Ext
{
    /// <summary>
    /// Provides all known Immersive Colors
    /// </summary>
    public enum ImmersiveColors
    {
        ImmersiveStartBackground,
        ImmersiveStartDesktopTilesBackground,
        ImmersiveStartDesktopTilesText,
        ImmersiveStartSystemTilesBackground,
        ImmersiveStartFocusRect,
        ImmersiveStartBackgroundDisabled,
        ImmersiveStartPrimaryText,
        ImmersiveStartSecondaryText,
        ImmersiveStartDisabledText,
        ImmersiveStartSelectionBackground,
        ImmersiveStartSelectionPrimaryText,
        ImmersiveStartHoverBackground,
        ImmersiveStartHoverPrimaryText,
        ImmersiveStartHighlight,
        ImmersiveStartInlineErrorText,
        ImmersiveStartControlLink,
        ImmersiveStartControlLinkVisited,
        ImmersiveStartControlLinkDisabled,
        ImmersiveStartControlLinkPressed,
        ImmersiveStartControlLinkMouseHover,
        ImmersiveStartControlLinkForegroundPressed,
        ImmersiveStartControlLinkBackgroundPressed,
        ImmersiveStartCommandRowRest,
        ImmersiveStartCommandRowHover,
        ImmersiveStartCommandRowPressed,
        ImmersiveStartCommandRowDisabled,
        ImmersiveStartCommandRowHighlight,
        ImmersiveStartFolderBackground,
        ImmersiveStartThumbnailPlaceholder,
        ImmersiveStartDefaultDarkFocusRect,
        ImmersiveStartDefaultLightFocusRect,
        ImmersiveSaturatedBackground,
        ImmersiveSaturatedBackgroundDisabled,
        ImmersiveSaturatedFocusRectDark,
        ImmersiveSaturatedFocusRect,
        ImmersiveSaturatedDefaultDarkFocusRect,
        ImmersiveSaturatedDefaultLightFocusRect,
        ImmersiveSaturatedPrimaryText,
        ImmersiveSaturatedSecondaryText,
        ImmersiveSaturatedSelectionBackground,
        ImmersiveSaturatedSelectionPrimaryText,
        ImmersiveSaturatedSelectionSecondaryText,
        ImmersiveSaturatedHoverBackground,
        ImmersiveSaturatedHoverPrimaryText,
        ImmersiveSaturatedHoverSecondaryText,
        ImmersiveSaturatedDivider,
        ImmersiveSaturatedHighlight,
        ImmersiveSaturatedInlineErrorText,
        ImmersiveSaturatedControlLink,
        ImmersiveSaturatedControlLinkVisited,
        ImmersiveSaturatedControlLinkDisabled,
        ImmersiveSaturatedControlLinkPressed,
        ImmersiveSaturatedControlLinkMouseHover,
        ImmersiveSaturatedControlLinkForegroundPressed,
        ImmersiveSaturatedControlLinkBackgroundPressed,
        ImmersiveSaturatedSystemToastBackground,
        ImmersiveSaturatedDesktopToastBackground,
        ImmersiveSaturatedFolderBackground,
        ImmersiveSaturatedThumbnailPlaceholder,
        ImmersiveSaturatedAltTabBackground,
        ImmersiveSaturatedAltTabHoverRect,
        ImmersiveSaturatedAltTabPressedRect,
        ImmersiveSaturatedCommandRowRest,
        ImmersiveSaturatedCommandRowHover,
        ImmersiveSaturatedCommandRowPressed,
        ImmersiveSaturatedCommandRowDisabled,
        ImmersiveSaturatedCommandRowHighlight,
        ImmersiveSaturatedSettingCharmSystemPaneButtonText,
        ImmersiveSaturatedSettingCharmSystemPaneButtonTextHover,
        ImmersiveSaturatedSettingCharmSystemPaneButtonTextPressed,
        ImmersiveSaturatedSettingCharmSystemPaneButtonTextSelected,
        ImmersiveSaturatedSettingCharmSystemPaneButtonTextDisabled,
        ImmersiveSaturatedSettingCharmSystemPaneButtonRest,
        ImmersiveSaturatedSettingCharmSystemPaneButtonHover,
        ImmersiveSaturatedSettingCharmSystemPaneButtonPressed,
        ImmersiveSaturatedSettingCharmSystemPaneButtonSelected,
        ImmersiveSaturatedSettingCharmSystemPaneButtonDisabled,
        ImmersiveSaturatedBackButtonBar,
        ImmersiveLightFocusRect,
        ImmersiveLightBackground,
        ImmersiveLightBackgroundDisabled,
        ImmersiveLightTitleText,
        ImmersiveLightPrimaryText,
        ImmersiveLightSecondaryText,
        ImmersiveLightTabText,
        ImmersiveLightSelectedTabText,
        ImmersiveLightSelectionBackground,
        ImmersiveLightSelectionPrimaryText,
        ImmersiveLightSelectionSecondaryText,
        ImmersiveLightHoverBackground,
        ImmersiveLightHoverPrimaryText,
        ImmersiveLightHoverSecondaryText,
        ImmersiveLightHighlight,
        ImmersiveLightInlineErrorText,
        ImmersiveLightWUNormal,
        ImmersiveLightWUWarning,
        ImmersiveLightWUError,
        ImmersiveLightControlLink,
        ImmersiveLightControlLinkVisited,
        ImmersiveLightControlLinkDisabled,
        ImmersiveLightControlLinkPressed,
        ImmersiveLightControlLinkMouseHover,
        ImmersiveLightControlLinkForegroundPressed,
        ImmersiveLightControlLinkBackgroundPressed,
        ImmersiveHardwarePrimaryText,
        ImmersiveHardwareClockBackground,
        ImmersiveHardwareClockText,
        ImmersiveHardwareCharmsBarBackground,
        ImmersiveHardwareCharmsBarBackgroundRest,
        ImmersiveHardwareCharmsBarBackgroundHotTrack,
        ImmersiveHardwareCharmsBarBackgroundPressed,
        ImmersiveHardwareCharmsBarText,
        ImmersiveHardwareCharmsBarTextDisabled,
        ImmersiveHardwareGutterRest,
        ImmersiveHardwareGutterDown,
        ImmersiveHardwareSettingCharmSystemPaneButtonText,
        ImmersiveHardwareSettingCharmSystemPaneButtonTextHover,
        ImmersiveHardwareSettingCharmSystemPaneButtonTextPressed,
        ImmersiveHardwareSettingCharmSystemPaneButtonTextSelected,
        ImmersiveHardwareSettingCharmSystemPaneButtonTextDisabled,
        ImmersiveHardwareSettingCharmSystemPaneButtonRest,
        ImmersiveHardwareSettingCharmSystemPaneButtonHover,
        ImmersiveHardwareSettingCharmSystemPaneButtonPressed,
        ImmersiveHardwareSettingCharmSystemPaneButtonSelected,
        ImmersiveHardwareSettingCharmSystemPaneButtonDisabled,
        ImmersiveHardwareKeyboardBackground,
        ImmersiveHardwareKeyboardKeyBackgroundDisabled,
        ImmersiveHardwareKeyboardKeyPrimaryTextDisabled,
        ImmersiveHardwareKeyboardKeySecondaryTextDisabled,
        ImmersiveHardwareKeyboardKeyBackgroundRest,
        ImmersiveHardwareKeyboardKeyPrimaryTextRest,
        ImmersiveHardwareKeyboardKeySecondaryTextRest,
        ImmersiveHardwareKeyboardKeyBackgroundPressed,
        ImmersiveHardwareKeyboardKeyPrimaryTextPressed,
        ImmersiveHardwareKeyboardKeySecondaryTextPressed,
        ImmersiveHardwareKeyboardKeyBackgroundHover,
        ImmersiveHardwareKeyboardDarkSpaceKeyBackgroundPressed,
        ImmersiveHardwareDefaultKeyboardKeyBackgroundRest,
        ImmersiveHardwareDefaultKeyboardKeyPrimaryTextRest,
        ImmersiveHardwareDefaultKeyboardKeySecondaryTextRest,
        ImmersiveHardwareDefaultKeyboardKeyBackgroundHover,
        ImmersiveHardwareKeyboardNumberKeyBackground,
        ImmersiveHardwareKeyboardNumberKeyBackgroundHover,
        ImmersiveHardwareKeyboardNumberKeyText,
        ImmersiveHardwareKeyboardFunctionKeyBackground,
        ImmersiveHardwareKeyboardFunctionKeyBackgroundHover,
        ImmersiveHardwareKeyboardFunctionKeyText,
        ImmersiveHardwareKeyboardFunctionKeyTextDisabled,
        ImmersiveHardwareKeyboardChildPanelBackground,
        ImmersiveHardwareKeyboardChildPanelKeyBackground,
        ImmersiveHardwareKeyboardChildKeyKeyText,
        ImmersiveHardwareKeyboardKeyBorder,
        ImmersiveHardwareHandwritingPanelBorder,
        ImmersiveHardwareHandwritingPanelKanjiConversionText,
        ImmersiveHardwareHandwritingPanelKanjiConversionBackground,
        ImmersiveHardwareHandwritingPanelInsertModeCharacter,
        ImmersiveHardwareHandwritingPanelSuggestedWord,
        ImmersiveHardwareHandwritingPanelCorrectionText,
        ImmersiveHardwareHandwritingPanelMatchedText,
        ImmersiveHardwareHandwritingPanelButtonRest,
        ImmersiveHardwareHandwritingPanelButtonHover,
        ImmersiveHardwareHandwritingPanelButtonPress,
        ImmersiveHardwareHandwritingPanelButtonBorder,
        ImmersiveHardwareHandwritingPanelConversionSelectedBackground,
        ImmersiveHardwareHandwritingPanelConversionUnselectedBackground,
        ImmersiveHardwareHandwritingPanelConversionSelectedText,
        ImmersiveHardwareHandwritingPanelConversionUnselectedText,
        ImmersiveHardwareTextPredictionBackgroundRest,
        ImmersiveHardwareTextPredictionBackgroundPressed,
        ImmersiveHardwareTextPredictionBorder,
        ImmersiveHardwareTextPredictionTextRest,
        ImmersiveHardwareTextPredictionTextPressed,
        ImmersiveHardwareControlLink,
        ImmersiveHardwareControlLinkVisited,
        ImmersiveHardwareControlLinkDisabled,
        ImmersiveHardwareControlLinkPressed,
        ImmersiveHardwareControlLinkMouseHover,
        ImmersiveControlTransparent,
        ImmersiveControlDarkRoundButtonOutlineDisabled,
        ImmersiveControlDarkRoundButtonOutlineLayerRest,
        ImmersiveControlDarkRoundButtonOutlineLayerHover,
        ImmersiveControlDarkRoundButtonOutlineLayerPressed,
        ImmersiveControlDarkRoundButtonGlyphDisabled,
        ImmersiveControlDarkRoundButtonGlyphLayerRest,
        ImmersiveControlDarkRoundButtonGlyphLayerHover,
        ImmersiveControlDarkRoundButtonGlyphLayerPressed,
        ImmersiveControlDarkRoundButtonFillLayerDisabled,
        ImmersiveControlDarkRoundButtonFillLayerRest,
        ImmersiveControlDarkRoundButtonFillLayerHover,
        ImmersiveControlDarkRoundButtonFillLayerPressed,
        ImmersiveControlLightRoundButtonOutlineDisabled,
        ImmersiveControlLightRoundButtonOutlineLayerRest,
        ImmersiveControlLightRoundButtonOutlineLayerHover,
        ImmersiveControlLightRoundButtonOutlineLayerPressed,
        ImmersiveControlLightRoundButtonGlyphDisabled,
        ImmersiveControlLightRoundButtonGlyphLayerRest,
        ImmersiveControlLightRoundButtonGlyphLayerHover,
        ImmersiveControlLightRoundButtonGlyphLayerPressed,
        ImmersiveControlLightRoundButtonFillLayerDisabled,
        ImmersiveControlLightRoundButtonFillLayerRest,
        ImmersiveControlLightRoundButtonFillLayerHover,
        ImmersiveControlLightRoundButtonFillLayerPressed,
        ImmersiveControlRadioButtonBackgroundSelected,
        ImmersiveControlRadioButtonBackgroundDisabledSelected,
        ImmersiveControlRadioButtonBackgroundDisabledHover,
        ImmersiveControlRadioButtonBackgroundDisabledPressed,
        ImmersiveControlRadioButtonTextDisabledSelected,
        ImmersiveControlRadioButtonTextDisabledHover,
        ImmersiveControlRadioButtonTextDisabledPressed,
        ImmersiveControlRadioButtonTextSelected,
        ImmersiveControlRadioButtonBorder,
        ImmersiveControlRadioButtonSeparator,
        ImmersiveControlDarkCheckboxLabelRest,
        ImmersiveControlDarkCheckboxBackgroundRest,
        ImmersiveControlDarkCheckboxBackgroundPressed,
        ImmersiveControlDarkCheckboxBackgroundDisabled,
        ImmersiveControlDarkCheckboxBackgroundHover,
        ImmersiveControlDarkCheckboxLabelHover,
        ImmersiveControlDarkCheckboxBorderRest,
        ImmersiveControlDarkCheckboxBorderPressed,
        ImmersiveControlDarkCheckboxBorderDisabled,
        ImmersiveControlDarkCheckboxBorderHover,
        ImmersiveControlDarkCheckboxLabelPressed,
        ImmersiveControlDarkCheckboxLabelDisabled,
        ImmersiveControlDarkCheckboxGlyphPressed,
        ImmersiveControlDarkCheckboxGlyphHover,
        ImmersiveControlDarkCheckboxGlyphRest,
        ImmersiveControlDarkCheckboxGlyphDisabled,
        ImmersiveControlLightCheckboxLabelPressed,
        ImmersiveControlLightCheckboxLabelRest,
        ImmersiveControlLightCheckboxBackgroundRest,
        ImmersiveControlLightCheckboxBackgroundPressed,
        ImmersiveControlLightCheckboxBackgroundDisabled,
        ImmersiveControlLightCheckboxBackgroundHover,
        ImmersiveControlLightCheckboxLabelHover,
        ImmersiveControlLightCheckboxBorderRest,
        ImmersiveControlLightCheckboxBorderPressed,
        ImmersiveControlLightCheckboxBorderDisabled,
        ImmersiveControlLightCheckboxBorderHover,
        ImmersiveControlLightCheckboxLabelDisabled,
        ImmersiveControlLightCheckboxGlyphPressed,
        ImmersiveControlLightCheckboxGlyphHover,
        ImmersiveControlLightCheckboxGlyphRest,
        ImmersiveControlLightCheckboxGlyphDisabled,
        ImmersiveControlDarkButtonBorderDisabled,
        ImmersiveControlDarkButtonTextDisabled,
        ImmersiveControlDarkButtonBorderPressed,
        ImmersiveControlDarkButtonTextHover,
        ImmersiveControlDarkButtonBorderHover,
        ImmersiveControlDarkButtonTextPressed,
        ImmersiveControlDarkButtonBorderRest,
        ImmersiveControlDarkButtonTextRest,
        ImmersiveControlDarkButtonBackgroundRest,
        ImmersiveControlDarkButtonBackgroundPressed,
        ImmersiveControlDarkButtonBackgroundDisabled,
        ImmersiveControlDarkButtonBackgroundHover,
        ImmersiveControlLightButtonBorderPressed,
        ImmersiveControlLightButtonBackgroundPressed,
        ImmersiveControlLightButtonBorderRest,
        ImmersiveControlLightButtonBackgroundRest,
        ImmersiveControlLightButtonBorderHover,
        ImmersiveControlLightButtonBorderDisabled,
        ImmersiveControlLightButtonBackgroundHover,
        ImmersiveControlLightButtonBackgroundDisabled,
        ImmersiveControlLightButtonTextHover,
        ImmersiveControlLightButtonTextDisabled,
        ImmersiveControlLightButtonTextPressed,
        ImmersiveControlLightButtonTextRest,
        ImmersiveControlDefaultDarkButtonTextPressed,
        ImmersiveControlDefaultDarkButtonTextHover,
        ImmersiveControlDefaultDarkButtonBorderRest,
        ImmersiveControlDefaultDarkButtonTextRest,
        ImmersiveControlDefaultDarkButtonBackgroundRest,
        ImmersiveControlDefaultDarkButtonBackgroundPressed,
        ImmersiveControlDefaultDarkButtonBorderHover,
        ImmersiveControlDefaultDarkButtonBorderPressed,
        ImmersiveControlDefaultDarkButtonBorderDisabled,
        ImmersiveControlDefaultDarkButtonTextDisabled,
        ImmersiveControlDefaultDarkButtonBackgroundDisabled,
        ImmersiveControlDefaultDarkButtonBackgroundHover,
        ImmersiveControlDefaultLightButtonBorderDisabled,
        ImmersiveControlDefaultLightButtonTextDisabled,
        ImmersiveControlDefaultLightButtonBorderPressed,
        ImmersiveControlDefaultLightButtonTextPressed,
        ImmersiveControlDefaultLightButtonTextRest,
        ImmersiveControlDefaultLightButtonTextHover,
        ImmersiveControlDefaultLightButtonBorderHover,
        ImmersiveControlDefaultLightButtonBorderRest,
        ImmersiveControlDefaultLightButtonBackgroundRest,
        ImmersiveControlDefaultLightButtonBackgroundHover,
        ImmersiveControlDefaultLightButtonBackgroundPressed,
        ImmersiveControlDefaultLightButtonBackgroundDisabled,
        ImmersiveControlDarkSelectBorderRest,
        ImmersiveControlDarkSelectBackgroundHover,
        ImmersiveControlDarkSelectBorderHover,
        ImmersiveControlDarkSelectBackgroundPressed,
        ImmersiveControlDarkSelectBorderPressed,
        ImmersiveControlDarkSelectBackgroundDisabled,
        ImmersiveControlDarkSelectTextRest,
        ImmersiveControlDarkSelectTextPressed,
        ImmersiveControlDarkSelectTextHover,
        ImmersiveControlDarkSelectGlyphDisabled,
        ImmersiveControlDarkSelectTextDisabled,
        ImmersiveControlDarkSelectBorderDisabled,
        ImmersiveControlDarkSelectGlyphRest,
        ImmersiveControlDarkSelectTextHighlighted,
        ImmersiveControlDarkSelectHighlightedTextPressed,
        ImmersiveControlDarkSelectHighlightPressed,
        ImmersiveControlDarkSelectHighlightSelected,
        ImmersiveControlDarkSelectHighlightHover,
        ImmersiveControlDarkSelectBackgroundRest,
        ImmersiveControlDarkSelectSecondaryTextPressed,
        ImmersiveControlDarkSelectSecondaryTextHighlighted,
        ImmersiveControlDarkSelectSecondaryTextHover,
        ImmersiveControlDarkSelectHighlightedSecondaryTextPressed,
        ImmersiveControlLightSelectBorderRest,
        ImmersiveControlLightSelectBackgroundRest,
        ImmersiveControlLightSelectBackgroundHover,
        ImmersiveControlLightSelectBorderHover,
        ImmersiveControlLightSelectBackgroundPressed,
        ImmersiveControlLightSelectBorderPressed,
        ImmersiveControlLightSelectBackgroundDisabled,
        ImmersiveControlLightSelectTextPressed,
        ImmersiveControlLightSelectGlyphDisabled,
        ImmersiveControlLightSelectTextDisabled,
        ImmersiveControlLightSelectBorderDisabled,
        ImmersiveControlLightSelectGlyphRest,
        ImmersiveControlLightSelectTextHighlighted,
        ImmersiveControlLightSelectHighlightedTextPressed,
        ImmersiveControlLightSelectHighlightPressed,
        ImmersiveControlLightSelectHighlightSelected,
        ImmersiveControlLightSelectTextHover,
        ImmersiveControlLightSelectTextRest,
        ImmersiveControlLightSelectHighlightHover,
        ImmersiveControlDarkRichEditBackgroundRest,
        ImmersiveControlDarkRichEditBorderRest,
        ImmersiveControlDarkRichEditBorderPressed,
        ImmersiveControlDarkRichEditBorderFocus,
        ImmersiveControlDarkRichEditBackgroundPressed,
        ImmersiveControlDarkRichEditBackgroundFocus,
        ImmersiveControlDarkRichEditBackgroundHover,
        ImmersiveControlDarkRichEditBackgroundDisabled,
        ImmersiveControlDarkRichEditBorderHover,
        ImmersiveControlDarkRichEditTextHelper,
        ImmersiveControlDarkRichEditTextRest,
        ImmersiveControlDarkRichEditTextFocus,
        ImmersiveControlDarkRichEditTextHighlighted,
        ImmersiveControlDarkRichEditTextDisabled,
        ImmersiveControlDarkRichEditBorderDisabled,
        ImmersiveControlDarkRichEditTextHover,
        ImmersiveControlDarkRichEditButtonBackgroundRest,
        ImmersiveControlDarkRichEditButtonBackgroundHover,
        ImmersiveControlDarkRichEditButtonBackgroundPressed,
        ImmersiveControlDarkRichEditButtonGlyphRest,
        ImmersiveControlDarkRichEditButtonGlyphHover,
        ImmersiveControlDarkRichEditButtonGlyphPressed,
        ImmersiveControlDarkRichEditHighlight,
        ImmersiveControlLightRichEditBackgroundRest,
        ImmersiveControlLightRichEditBorderRest,
        ImmersiveControlLightRichEditBorderPressed,
        ImmersiveControlLightRichEditBorderFocus,
        ImmersiveControlLightRichEditBackgroundPressed,
        ImmersiveControlLightRichEditBackgroundFocus,
        ImmersiveControlLightRichEditBackgroundHover,
        ImmersiveControlLightRichEditBackgroundDisabled,
        ImmersiveControlLightRichEditBorderHover,
        ImmersiveControlLightRichEditTextHelper,
        ImmersiveControlLightRichEditTextRest,
        ImmersiveControlLightRichEditTextFocus,
        ImmersiveControlLightRichEditTextDisabled,
        ImmersiveControlLightRichEditBorderDisabled,
        ImmersiveControlLightRichEditTextHover,
        ImmersiveControlLightRichEditButtonBackgroundRest,
        ImmersiveControlLightRichEditButtonBackgroundHover,
        ImmersiveControlLightRichEditButtonBackgroundPressed,
        ImmersiveControlLightRichEditButtonGlyphRest,
        ImmersiveControlLightRichEditButtonGlyphHover,
        ImmersiveControlLightRichEditButtonGlyphPressed,
        ImmersiveControlLightRichEditHighlight,
        ImmersiveControlTooltipBackground,
        ImmersiveControlTooltipDomainText,
        ImmersiveControlTooltipText,
        ImmersiveControlSliderTooltipText,
        ImmersiveControlTooltipBorder,
        ImmersiveControlDarkProgressBackground,
        ImmersiveControlDarkProgressForeground,
        ImmersiveControlLightProgressBackground,
        ImmersiveControlLightProgressForeground,
        ImmersiveControlProgressBorder,
        ImmersiveControlDarkToggleLabelDisabled,
        ImmersiveControlLightToggleLabelDisabled,
        ImmersiveControlDarkToggleOnOffTextDisabled,
        ImmersiveControlDarkToggleOnOffTextEnabled,
        ImmersiveControlLightToggleOnOffTextDisabled,
        ImmersiveControlLightToggleOnOffTextEnabled,
        ImmersiveControlDarkToggleThumbDisabled,
        ImmersiveControlLightToggleThumbDisabled,
        ImmersiveControlDarkToggleTrackBackgroundDisabled,
        ImmersiveControlLightToggleTrackBackgroundDisabled,
        ImmersiveControlDarkToggleTrackBorderDisabled,
        ImmersiveControlLightToggleTrackBorderDisabled,
        ImmersiveControlDarkToggleTrackFillDisabled,
        ImmersiveControlLightToggleTrackFillDisabled,
        ImmersiveControlDarkToggleTrackGutterDisabled,
        ImmersiveControlLightToggleTrackGutterDisabled,
        ImmersiveControlDarkSliderThumbDisabled,
        ImmersiveControlDarkSliderThumbHover,
        ImmersiveControlDarkSliderThumbPressed,
        ImmersiveControlDarkSliderThumbRest,
        ImmersiveControlLightSliderThumbDisabled,
        ImmersiveControlLightSliderThumbHover,
        ImmersiveControlLightSliderThumbPressed,
        ImmersiveControlLightSliderThumbRest,
        ImmersiveControlDarkSliderTickMark,
        ImmersiveControlLightSliderTickMark,
        ImmersiveControlDarkSliderTrackBackgroundDisabled,
        ImmersiveControlDarkSliderTrackBackgroundHover,
        ImmersiveControlDarkSliderTrackBackgroundPressed,
        ImmersiveControlDarkSliderTrackBackgroundRest,
        ImmersiveControlLightSliderTrackBackgroundDisabled,
        ImmersiveControlLightSliderTrackBackgroundHover,
        ImmersiveControlLightSliderTrackBackgroundPressed,
        ImmersiveControlLightSliderTrackBackgroundRest,
        ImmersiveControlDarkSliderTrackBufferingDisabled,
        ImmersiveControlDarkSliderTrackBufferingHover,
        ImmersiveControlDarkSliderTrackBufferingPressed,
        ImmersiveControlDarkSliderTrackBufferingRest,
        ImmersiveControlLightSliderTrackBufferingDisabled,
        ImmersiveControlLightSliderTrackBufferingHover,
        ImmersiveControlLightSliderTrackBufferingPressed,
        ImmersiveControlLightSliderTrackBufferingRest,
        ImmersiveControlDarkSliderTrackFillDisabled,
        ImmersiveControlDarkSliderTrackFillHover,
        ImmersiveControlDarkSliderTrackFillPressed,
        ImmersiveControlDarkSliderTrackFillRest,
        ImmersiveControlLightSliderTrackFillDisabled,
        ImmersiveControlLightSliderTrackFillHover,
        ImmersiveControlLightSliderTrackFillPressed,
        ImmersiveControlLightSliderTrackFillRest,
        ImmersiveControlDarkToggleLabelEnabled,
        ImmersiveControlLightToggleLabelEnabled,
        ImmersiveControlDarkToggleThumbEnabled,
        ImmersiveControlLightToggleThumbEnabled,
        ImmersiveControlDarkToggleTrackBackgroundEnabled,
        ImmersiveControlLightToggleTrackBackgroundEnabled,
        ImmersiveControlDarkToggleTrackBorderEnabled,
        ImmersiveControlLightToggleTrackBorderEnabled,
        ImmersiveControlDarkToggleTrackFillEnabled,
        ImmersiveControlLightToggleTrackFillEnabled,
        ImmersiveControlDarkToggleTrackGutterEnabled,
        ImmersiveControlLightToggleTrackGutterEnabled,
        ImmersiveControlDefaultFocusRectDark,
        ImmersiveControlDefaultFocusRectLight,
        ImmersiveControlContextMenuBackgroundRest,
        ImmersiveControlContextMenuBackgroundPressed,
        ImmersiveControlContextMenuBackgroundHover,
        ImmersiveControlContextMenuTextRest,
        ImmersiveControlContextMenuTextPressed,
        ImmersiveControlContextMenuSeparator,
        ImmersiveBootBackground,
        ImmersiveBootTitleText,
        ImmersiveBootPrimaryText,
        ImmersiveBootSecondaryText,
        ImmersiveBootConfirmationButton,
        ImmersiveBootMenuButtonGlyphBackground,
        ImmersiveBootMenuButtonMouseHover,
        ImmersiveBootMenuButtonPressedHighlight,
        ImmersiveBootMenuButtonFocusRect,
        ImmersiveBootProgressText,
        ImmersiveBootErrorText,
        ImmersiveBootEditBackground,
        ImmersiveBootTextLinkRest,
        ImmersiveBootTextLinkHover,
        ImmersiveBootTextLinkPressed,
    }
}

