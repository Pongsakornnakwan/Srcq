using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using RichnessSoft.Web2.Component.Control;
using RichnessSoft.Web2.Shared;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RichnessSoft.Web2.Pages.SO
{
    public partial class QT

    {
        [Parameter]
        public string ParrentMenu { get; set; }

        private bool _loaded;
        List<OrderTrnH> ListData { get; set; } = new List<OrderTrnH>();
        public int selectUM = 0;
        public int SelectBranch = 0;
        public int SelectBook = 0;
        private DateTime BegDate { get; set; }
        private DateTime EndDate { get; set; }

        RcBranch oRcBranch;
        RcBook oRcBook;

        protected override void OnInitialized()
        { }
        protected override async Task OnInitializedAsync()
        {
            _loaded = true;
            await CheckState();

            LoadData();
            _loaded = false;
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                this.getOptionData();
                BegDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);
                EndDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month));
            }

        }

        private void getOptionData()
        {
            if (this.oRcBranch is not null && (this.oRcBranch?.gmRowCount ?? 0) > 0)
            {
                this.SelectBranch = this.oRcBranch?.gmGetRowData(0)?.id ?? 0;
            }
            this.SelectBook = 0;
            if (this.oRcBook is not null)
            {
                this.oRcBook.LoadDataSource(store.companyid, SelectBranch, GbDocRefType.SALE.QUOTATION);
                if (this.oRcBook.gmRowCount > 0)
                {
                    SelectBook = this.oRcBook.gmGetRowData(0)?.id ?? 0;
                }
            }
            this.StateHasChanged();
        }

        async void LoadData()
        {
            ListData = await orderTrnHService.GetAllData(store.companyid, SelectBranch, GbDocRefType.SALE.QUOTATION, SelectBook, BegDate, EndDate);
        }
        async void SelectChange(string Table, object value)
        {
            if (value == null)
                return;

            switch (Table)
            {
                case "BRANCH":
                    SelectBranch = (value as Branch)?.id ?? 0;
                    break;
                case "BOOK":
                    SelectBook = (value as Book)?.id ?? 0;
                    break;
                default:
                    break;
            }
            LoadData();
            StateHasChanged();
        }

        void BegDateChange(DateTime? date)
        {
            BegDate = (date?? new DateTime());
            LoadData();
            StateHasChanged();
        }

        void EndDateChange(DateTime? date)
        {
            BegDate = (date ?? new DateTime());
            LoadData();
            StateHasChanged();
        }
    }
}