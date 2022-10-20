using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Component.Shared
{
    public class WebConstUtil
    {
        public class Control
        {
            public const DevExpress.Blazor.SizeMode goTextSize = DevExpress.Blazor.SizeMode.Small;
            public const DevExpress.Blazor.SizeMode goComboboxSize = DevExpress.Blazor.SizeMode.Small;
            public const DevExpress.Blazor.SizeMode goSpinEditSize = DevExpress.Blazor.SizeMode.Small;
            public const DevExpress.Blazor.SizeMode goDateEditSize = DevExpress.Blazor.SizeMode.Small;
            public const DevExpress.Blazor.SizeMode goDxDataGridSize = DevExpress.Blazor.SizeMode.Small;
            public const DevExpress.Blazor.SizeMode goDxButtonSize = DevExpress.Blazor.SizeMode.Medium;
            public const DevExpress.Blazor.SizeMode goDxButtonSizeSmall = DevExpress.Blazor.SizeMode.Small;
            public enum ControlType { TEXT, COMBOBOX, SPINEDIT, DATE, BUTTON, BUTTON_SMALL };
            public static string GetFormControlSize(ControlType controlType)
            {
                string strRetValue = "";
                switch (controlType)
                {
                    case ControlType.TEXT:
                        switch (goTextSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    case ControlType.COMBOBOX:
                        switch (goComboboxSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    case ControlType.SPINEDIT:
                        switch (goSpinEditSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    case ControlType.DATE:
                        switch (goDateEditSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    case ControlType.BUTTON:
                        switch (goDxButtonSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    case ControlType.BUTTON_SMALL:
                        switch (goDxButtonSizeSmall)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "form-control form-control-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "form-control";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "form-control form-control-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        strRetValue = "form-control";
                        break;
                }
                return strRetValue;
            }
            public static string GetInputGroupSize(ControlType controlType)
            {
                string strRetValue = "";
                switch (controlType)
                {
                    case ControlType.TEXT:
                    case ControlType.COMBOBOX:
                    case ControlType.SPINEDIT:
                    case ControlType.DATE:
                    case ControlType.BUTTON:
                        switch (goTextSize)
                        {
                            case DevExpress.Blazor.SizeMode.Small:
                                strRetValue = "input-group input-group-sm";
                                break;
                            case DevExpress.Blazor.SizeMode.Medium:
                                strRetValue = "input-group";
                                break;
                            case DevExpress.Blazor.SizeMode.Large:
                                strRetValue = "input-group input-group-lg";
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        strRetValue = "input-group";
                        break;
                }
                return strRetValue;
            }
        }
    }
}
