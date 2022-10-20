using BlazorInputFile;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using Microsoft.AspNetCore.Hosting;
using IFileListEntry = BlazorInputFile.IFileListEntry;
using static RichnessSoft.Service.FileUpload;

namespace RichnessSoft.Service
{
    public interface IFileUpload
    {
        Task<ResultModel> gmUploadFileAsync(ActionType actionType, IFileListEntry fileEntry, string sourceName);
        ResultModel gmUploadFile(ActionType actionType, MemoryStream stream, string sourceName);
        ResultModel gmDeleteFile(ActionType actionType, string[] filename);
        public string gmDirectoryUpload(ActionType actionType);
    }

    public class FileUpload : IFileUpload
    {
        public enum ActionType { PRODUCT = 0, VENDOR = 1, CUSTOMER = 2, SALE_PERSON = 3, QUOATATION = 4, SALE_ORDER = 5, INVOICE = 6, BILL = 7, PRE_RECEIPT = 8, RECEIPT = 9 };

        private readonly IWebHostEnvironment _environment;
        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task<ResultModel> gmUploadFileAsync(ActionType actionType, IFileListEntry fileEntry, string sourceName)
        {
            ResultModel result;
            try
            {
                string strRootDirectory = this.gmDirectoryUpload(actionType);
                if (UtilHelper.gmIsNullOrEmpty(strRootDirectory))
                {
                    return new ResultModel { Data = null, Message = "Directory is empty!", Success = false };
                }
                if (!Directory.Exists(strRootDirectory))
                {
                    Directory.CreateDirectory(strRootDirectory);
                }
                var path = Path.Combine(strRootDirectory, sourceName);
                using (var ms = new MemoryStream())
                {
                    await fileEntry.Data.CopyToAsync(ms);
                    using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        ms.WriteTo(file);
                    }
                }
                result = new ResultModel { Success = true, Message = "Upload Success" };
            }
            catch (Exception ex)
            {
                result = new ResultModel { Success = false, Message = ex.Message };
            }
            return result;
        }
        public ResultModel gmUploadFile(ActionType actionType, MemoryStream stream, string sourceName)
        {
            ResultModel result;
            try
            {
                string strRootDirectory = this.gmDirectoryUpload(actionType);
                if (UtilHelper.gmIsNullOrEmpty(strRootDirectory))
                {
                    return new ResultModel { Data = null, Message = "Directory is empty!", Success = false };
                }
                if (!Directory.Exists(strRootDirectory))
                {
                    Directory.CreateDirectory(strRootDirectory);
                }
                var path = Path.Combine(strRootDirectory, sourceName);
                if (stream is not null)
                {
                    using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        stream.WriteTo(file);
                    }
                }
                result = new ResultModel { Success = true, Message = "Upload Success" };
            }
            catch (Exception ex)
            {
                result = new ResultModel { Success = false, Message = ex.Message };
            }
            return result;
        }
        public ResultModel gmDeleteFile(ActionType actionType, string[] filenames)
        {
            ResultModel result;
            try
            {
                string[] files = new string[] { };
                string strRootDirectory = this.gmDirectoryUpload(actionType);
                if (UtilHelper.gmIsNullOrEmpty(strRootDirectory))
                {
                    return new ResultModel { Data = null, Message = "Directory is empty!", Success = false };
                }
                else if (Directory.Exists(strRootDirectory) == false)
                {
                    return new ResultModel { Data = null, Message = "Directory does not exists!", Success = false };
                }
                else
                {
                    foreach (var filename in filenames)
                    {
                        files = Directory.GetFiles(strRootDirectory, filename, SearchOption.AllDirectories);
                        if (files.Length > 0)
                        {
                            var strFileName = Path.Combine(strRootDirectory, filename);
                            if (File.Exists(strFileName))
                            {
                                File.Delete(strFileName);
                            }
                        }
                    }
                }
                result = new ResultModel { Success = true, Message = "Deleted Success" };
            }
            catch (Exception ex)
            {
                result = new ResultModel { Success = false, Message = ex.Message };
            }
            return result;
        }
        public string gmDirectoryUpload(ActionType actionType = ActionType.QUOATATION)
        {
            string strRootDirectory = "";
            switch (actionType)
            {
                case ActionType.PRODUCT:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "product");
                    break;
                case ActionType.VENDOR:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "vendor");
                    break;
                case ActionType.CUSTOMER:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "customer");
                    break;
                case ActionType.SALE_PERSON:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "signature");
                    break;
                case ActionType.QUOATATION:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "quotations");
                    break;
                case ActionType.SALE_ORDER:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "sale_orders");
                    break;
                case ActionType.INVOICE:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "invoices");
                    break;
                case ActionType.BILL:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "bills");
                    break;
                case ActionType.PRE_RECEIPT:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "pre_receipts");
                    break;
                case ActionType.RECEIPT:
                    strRootDirectory = Path.Combine(_environment.WebRootPath, "upload", "receipts");
                    break;
                default:
                    break;
            }
            return strRootDirectory;
        }
    }
}
