using NLog;
using Registration.Api.Interfaces;
using System;
using System.Web;

namespace Registration.Api.Services
{
    public class NLogService : ILog
    {
        private readonly Logger logger;

        public NLogService()
        {
            this.logger = LogManager.GetCurrentClassLogger();
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception e, string message, params object[] args)
        {
            logger.Error(e, message, args);
        }

        public void Error(Exception e)
        {
            Error(BuildExceptionMessage(e));
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        private string BuildExceptionMessage(Exception ex)
        {
            var exception = ex;

            if(ex.InnerException != null)
            {
                exception = ex.InnerException;
            }

            var path = "not available";
            var rawUrl = "not available";

            if (HttpContext.Current != null && HttpContext.Current.Request != null && HttpContext.Current.Request.Path != null)
            {
                path = HttpContext.Current.Request.Path;
            }

            if (HttpContext.Current != null && HttpContext.Current.Request != null && HttpContext.Current.Request.RawUrl != null)
            {
                rawUrl = HttpContext.Current.Request.RawUrl;
            }

            var errorMessage = Environment.NewLine + "Error in Path :" + path;
            errorMessage = Environment.NewLine + "Raw Url :" + rawUrl;
            errorMessage += Environment.NewLine + "Message :" + exception.Message;
            errorMessage += Environment.NewLine + "Source :" + exception.Source;
            errorMessage += Environment.NewLine + "Stack Trace :" + exception.StackTrace;
            errorMessage += Environment.NewLine + "TargetSite :" + exception.TargetSite;

            return errorMessage;
        }
    }
}