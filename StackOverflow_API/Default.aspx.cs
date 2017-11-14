using System;
using StackOverflow_API.Models;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace StackOverflow_API
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strResult = GetQuestInfo();
                lblMessages.Text = strResult.ToString();
            }
        }



        static string RequestWebData(string URL)
        {
            
            ExtendedWebClient client = new ExtendedWebClient();
            return client.DownloadString(URL);

        }

        private string  GetQuestInfo()
        {
            try
            {
                string URL = "https://api.stackexchange.com/2.2/questions?pagesize=50&order=desc&sort=creation&site=stackoverflow";
                string jsonData = RequestWebData(URL);

                var alldatas = SeQuestionInfoBase.FromJson(jsonData);

                GvQuestions.DataSource = alldatas.questions;
                GvQuestions.DataBind();
                return "Page updated @ "+ DateTime.Now.ToString();
               
            }
            catch (Exception ex)
            {
                 return "Error Occured " + ex.Message;
               
            }
        }

        protected  void btnRefresh_Click(object sender, EventArgs e)
        {
            string strResult = GetQuestInfo();
            lblMessages.Text = strResult.ToString();
            
        }
    }

}