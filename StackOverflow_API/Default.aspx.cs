using System;
using StackOverflow_API.Models;
namespace StackOverflow_API
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetQuestInfo();
            }
        }



        static string RequestWebData(string URL)
        {
            
            ExtendedWebClient client = new ExtendedWebClient();
            return client.DownloadString(URL);

        }

        public void GetQuestInfo()
        {
            string URL = "https://api.stackexchange.com/2.2/questions?pagesize=50&order=desc&sort=creation&site=stackoverflow";
            string jsonData = RequestWebData(URL);

            var alldatas = SeQuestionInfoBase.FromJson(jsonData);

            GvQuestions.DataSource = alldatas.questions;
            GvQuestions.DataBind();

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            GetQuestInfo();
        }
    }

}