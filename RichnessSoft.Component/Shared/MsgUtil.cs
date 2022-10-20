using Blazored.Modal;
using Blazored.Modal.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using RichnessSoft.Common;
using RichnessSoft.Component.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Component.Shared
{
    public class MsgUtil
    {
        private readonly SweetAlertService? _sweet;
        private readonly IModalService _Modal;

        private SweetAlertOptions? _option;
        private bool _ConfirmResult;
        public bool ConfirmResult
        {
            get { return _ConfirmResult; }
            set
            {
                _ConfirmResult = value;
            }
        }
        public MsgUtil(SweetAlertService swl, IModalService Modal)
        {
            _sweet = swl;
            _ConfirmResult = false;
            _Modal = Modal;
        }

        public Task<SweetAlertResult> Show(string message = "")
        {
            return Show("", message);
        }
        public Task<SweetAlertResult> Show(string title = "", string message = "")
        {
            return Show(title, message, "");
        }
        public Task<SweetAlertResult> Show(string title = "", string message = "", string target = "")
        {
            return Show(title, message, target, "info");
        }
        public Task<SweetAlertResult> Show(string title = "", string message = "", string target = "", SweetAlertIcon? icon = default)
        {
            return Show(title, message, target, (icon?.ToString() ?? "info"));
        }
        public async Task<SweetAlertResult> Show(string title = "", string message = "", string target = "", string icon = "info")
        {
            if (_sweet is null) { return new SweetAlertResult(); }
            _option = new SweetAlertOptions()
            {
                AllowEnterKey = true,
                AllowEscapeKey = true,
                AllowOutsideClick = true,
                Backdrop = true,
                //Target = target,
                Text = message,
                Title = title,
                Icon = SweetAlertIcon.FromString(icon),
                Position = SweetAlertPosition.Center,
                StopKeydownPropagation = true,
            };
            return await _sweet.FireAsync(_option);
        }
        public async Task<SweetAlertResult> ShowWithHtml(string title = "", string html = "", string target = "", SweetAlertIcon? icon = default)
        {
            if (_sweet is null) { return new SweetAlertResult(); }
            _option = new SweetAlertOptions()
            {
                AllowEnterKey = true,
                AllowEscapeKey = true,
                AllowOutsideClick = true,
                Backdrop = true,
                Html = html,
                Title = title,
                Icon = (icon ?? SweetAlertIcon.Info),
                Position = SweetAlertPosition.Center,
                StopKeydownPropagation = true,

            };
            return await _sweet.FireAsync(_option);
        }
        async public Task<bool> Confirm(string message = "") => await Confirm("", message);
        async public Task<bool> Confirm(string title = "", string message = "") => await Confirm(title, message, "", "");

        async public Task<bool> Confirm(string title = "", string message = "", string ConfirmButtonText = "", string CancelButtonText = "")
        {
            bool bConfirmed = false;
            string strModalTitle = UtilHelper.gmIsNullOrEmpty(title) ? Lang.SysCode("ยืนยัน", "Confirm") : title;
            string strConfirmButtonText = UtilHelper.gmIsNullOrEmpty(ConfirmButtonText) ? Lang.SysCode("ตกลง", "OK") : ConfirmButtonText;
            string strCancelButtonText = UtilHelper.gmIsNullOrEmpty(CancelButtonText) ? Lang.SysCode("ยกเลิก", "CANCEL") : CancelButtonText;

            var options = new ModalOptions { ContentScrollable = true, FocusFirstElement = true, HideCloseButton = true, Position = ModalPosition.Center, UseCustomLayout = true, DisableBackgroundCancel = false };
            var parameters = new ModalParameters();
            parameters.Add(nameof(RcPopupConfirm.goModalID), "iPopupConfrimMsg");
            parameters.Add(nameof(RcPopupConfirm.goModalTitle), strModalTitle);
            parameters.Add(nameof(RcPopupConfirm.goModalText), message);
            parameters.Add(nameof(RcPopupConfirm.goModalConfirmButtonText), strConfirmButtonText);
            parameters.Add(nameof(RcPopupConfirm.goModalCancelButtonText), strCancelButtonText);
            if (_Modal is not null)
            {
                var oModal = _Modal.Show<RcPopupConfirm>(strModalTitle, parameters, options);
                if (oModal is not null)
                {
                    var oResultPopup = await oModal.Result;
                    if (oResultPopup is not null)
                    {
                        bConfirmed = !oResultPopup.Cancelled;
                    }
                    oModal.Close(oResultPopup);
                }
            }
            return bConfirmed;
        }

        //public bool Confirm(string title = "", string message = "", string target = "")
        //{
        //    if (_sweet is null) { return false; }
        //    _option = new SweetAlertOptions()
        //    {
        //        AllowEnterKey = true,
        //        AllowEscapeKey = true,
        //        AllowOutsideClick = true,
        //        Backdrop = false,
        //        Target = target,
        //        Text = message,
        //        Title = title,
        //        icon = SweetAlertIcon.Question,
        //        ShowCancelButton = true,
        //        ConfirmButtonText = Lang.SysCode("ตกลง","OK"),
        //        CancelButtonText = Lang.SysCode("ยกเลิก","CANCEL")
        //    };
        //    return _sweet.FireAsync(_option).Result.IsConfirmed;
        //}
    }
}
