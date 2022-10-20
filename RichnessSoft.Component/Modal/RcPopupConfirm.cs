using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using RichnessSoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichnessSoft.Component.Modal
{
    public partial class RcPopupConfirm
    {

        [Parameter]
        public string goModalID { get; set; } = "iPopupConfirm";
        [Parameter]
        public string goModalTitle { get; set; } = Lang.SysCode("ยืนยัน", "Confirm");
        [Parameter]
        public string goModalText { get; set; } = "";
        [Parameter]
        public string goModalConfirmButtonText { get; set; } = Lang.SysCode("ตกลง", "OK");
        [Parameter]
        public string goModalCancelButtonText { get; set; } = Lang.SysCode("ยกเลิก", "CANCEL");

        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        protected override void OnInitialized()
        {
            if (BlazoredModal is not null)
            {
                BlazoredModal.SetTitle(this.goModalTitle);
            }
        }

        #region Function

        #endregion

        #region Event
        async Task SubmitForm()
        {
            await BlazoredModal.CloseAsync(ModalResult.Ok<RcPopupConfirm>(this));
        }
        async Task Close() => await BlazoredModal.CancelAsync();
        async Task Cancel() => await BlazoredModal.CancelAsync();
        #endregion
    }
}