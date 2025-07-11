﻿using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GAIL_QUIZ1
{
    public partial class quizadmin_results : Page
    {
        private readonly string connStr = ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindCompletedQuizzes();
        }

        private void BindCompletedQuizzes()
        {
            int adminId = Session["EMP_NO"] != null ? Convert.ToInt32(Session["EMP_NO"]) : 0;

            string sql = @"
                SELECT 
                    rq.QUIZ_ID,
                    rq.QUIZ_TITLE,
                    rq.DEPARTMENT,
                    hd.LOCATION,
                    rq.QUIZ_DATE,
                    rq.QUIZ_START_TIME,
                    rq.QUIZ_END_TIME
                FROM QUIZ_REQUEST rq
                JOIN ERP_HR_DAT hd ON rq.REQUESTED_BY = hd.EMP_NO
                WHERE rq.REQUESTED_BY = @adminId
                  AND rq.QUIZ_STATUS = 'Approved'
                  AND rq.QUIZ_END_TIME < NOW()
                ORDER BY rq.QUIZ_DATE DESC;
            ";

            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@adminId", adminId);
                da.Fill(dt);
            }

            // Add row numbers
            dt.Columns.Add("RowNum", typeof(int));
            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["RowNum"] = i + 1;

            gvCompleted.DataSource = dt;
            gvCompleted.DataBind();
        }

        protected void gvCompleted_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewResults")
            {
                int quizId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect($"quizadmin_results_participants.aspx?quizId={quizId}", false);
                Context.ApplicationInstance.CompleteRequest(); // Prevents thread abort on some servers
            }
        }
    }
}
