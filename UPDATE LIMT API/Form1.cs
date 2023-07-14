using ArgIT.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Rootobject

{

    public string type { get; set; }

    public string code { get; set; }
    public string description { get; set; }





    public Resultpay1 result { get; set; }





}
public class Resultpay1





{





    public Balancelist1[] BalanceList { get; set; }





}
public class Balancelist1





{





    public string limitHeader { get; set; }





    public Limitobject1 limitObject { get; set; }





}







public class Limitobject1





{





    public Rmstemplatemap1 RMSTemplateMap { get; set; }





    public Rmssublimits1 RMSSubLimits { get; set; }





    public Marginavailable1 marginAvailable { get; set; }





    public string AccountID { get; set; }





}





public class Rmstemplatemap1





{





    public string RMSEntityLevelId { get; set; }





    public int EntityType { get; set; }





    public string EntityId { get; set; }





    public int RMSSegment { get; set; }





    public int RMSExchange { get; set; }





    public int RMSProduct { get; set; }





    public string TemplateName { get; set; }





    public int EntityLimitId { get; set; }





    public int EntityMarginId { get; set; }





    public Entitylimitfieldidlist1 EntityLimitFieldIdList { get; set; }





    public Entitymarginfieldidlist1 EntityMarginFieldIdList { get; set; }





    public string CreatedBy { get; set; }





    public string UpdatedBy { get; set; }





    public DateTime CreatedOn { get; set; }





    public DateTime LastUpdatedOn { get; set; }





    public bool IsGroupWiseValidationRequired { get; set; }





    public string EntityKey { get; set; }





    public string Level { get; set; }





}
public class Rmssublimits1





{





    public string cashAvailable { get; set; }





    public float collateral { get; set; }





    public string netMarginAvailable { get; set; }





    public string MTM { get; set; }





    public string UnrealizedMTM { get; set; }





    public string RealizedMTM { get; set; }





}







public class Marginavailable1





{
    public string CashMarginAvailable { get; set; }
    public string AdhocMargin { get; set; }
    public string NotinalCash { get; set; }
    public string PayInAmount { get; set; }
    public string PayOutAmount { get; set; }
    public string CNCSellBenifit { get; set; }
    public string DirectCollateral { get; set; }
    public string HoldingCollateral { get; set; }
    public string ClientBranchAdhoc { get; set; }
    public string SellOptionsPremium { get; set; }
    public string TotalBranchAdhoc { get; set; }
    public string AdhocFOMargin { get; set; }
    public string AdhocCurrencyMargin { get; set; }
    public string AdhocCommodityMargin { get; set; }
    public string AdhoALL { get; set; }
}






public class Entitylimitfieldidlist1





{
    public long CNCLimit { get; set; }
    public long GrossExpLimit { get; set; }
    public long BuyExpLimit { get; set; }
    public long SellExpLimit { get; set; }
    public long TurnOverLimit { get; set; }
    public string SLBMLimit { get; set; }
    public string MToMLossLimit { get; set; }
    public long GrossExpDerLimit { get; set; }
    public long BuyExpFUTLimit { get; set; }
    public long SellExpFUTLimit { get; set; }
    public float BuyExpOPTLimit { get; set; }
    public long SellExpOTPLimit { get; set; }





}







public class Entitymarginfieldidlist1





{
    public int CashMarginAvailable { get; set; }
    public int CashAdhocMargin { get; set; }
    public int NotionalCash { get; set; }
    public int PayInAmount { get; set; }
    public int PayOutAmount { get; set; }
    public int CNCSellBenefit { get; set; }
    public int DirectCollateral { get; set; }
    public float HoldingCollateral { get; set; }
    public int SellOptionPremium { get; set; }
    public int ClientBranchAdhoc { get; set; }
    public int MaxtBranchAdhocToClient { get; set; }
    public int TotalBranchAdhoc { get; set; }
    public int AdhocFOMargin { get; set; }
    public int AdhocCurrencyMargin { get; set; }
    public int AdhocCommodityMargin { get; set; }
    public int AdhocMargin { get; set; }
    public int undefined { get; set; }
}





public class Personlimit





{
    public string LoginId { get; set; }
    public string ClientId { get; set; }
    public int CashMarginAvailable { get; set; }
    //public int AdhocAll { get; set; }
    public int RMSSegment { get; set; }
    public int RMSExchange { get; set; }
    public int RMSProduct { get; set; }
}







class RMS_fieldslimit





{
    public string LoginId { get; set; }
    public string ClientId { get; set; }
    public int NotionalCash { get; set; }
    public int PayInAmout { get; set; }
    public int PayOutAmout { get; set; }
    public int DirectCollatral { get; set; }
    public int AdhocAll { get; set; }
    public int AdhocCashNRML { get; set; }
    public int AdhocCashMIS { get; set; }
    public int AdhocFONRML { get; set; }
    public int AdhocFOMIS { get; set; }
    public int AdhocCURNRML { get; set; }
    public int AdhocCURMIS { get; set; }
    public int AdhocCOMNRML { get; set; }
    public int AdhocCOMMIS { get; set; }
    public int AdhocCashCNC { get; set; }
    public bool IsIncrementValue { get; set; }
    public int RMSSegment { get; set; }
    public int RMSExchange { get; set; }
    public int RMSProduct { get; set; }
}
public class clsResult
{
    //public clsResult()
    //{
    //    this.type = "";
    //    this.code ="";
    //    this.description="";
    //    this.result =new clsResultInner();
    //}
    //public string type { get; set; }
    //public string code { get; set; }
    //public string description { get; set; }
    public clsResultInner result { get; set; }
}





public class clsResultInner





{





    //public string UserID { get; set; }





    public string Token { get; set; }





}
namespace UPDATE_LIMT_API
{
    public partial class Form1 : Form
    {
        private const string URL = "https://algozy.rathi.com:3000/backofficeapi/login#";
        private const string DATA = @"{""userID"": ""Symphony"",""password"": ""sft@1234$""}";
        SqlConnection connrms = new SqlConnection("SERVER=192.168.10.8;DATABASE=ENETMIS;UID=PROD_APP_USER;PASSWORD=2@22#Rms$appuser");
        string URL_rms_fields = "https://algozy.rathi.com:3000/backofficeapi/updatermslimit/rmsfields#";
        private const string URL_Limit = "https://algozy.rathi.com:3000/backofficeapi/updatermslimit#";
        private const string DATA_limit = @"{""LoginId"": ""ADMIN2"",""ClientId"": ""TEST110"",""CashMarginAvailable"": 500 ,""RMSSegment"" : 31,""RMSExchange"" : 31,""RMSProduct"" : 63}";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsFill = new DataSet();
            SqlParameter[] _sql = new SqlParameter[0];
            //dsFill = SqlHelper.ExecuteDataset(connrms, CommandType.StoredProcedure, "usp_limit_request_update_symphony_sayali", _sql);
            dsFill = SqlHelper.ExecuteDataset(connrms, CommandType.StoredProcedure, "usp_limit_request_update_symphony_sayali_test", _sql);
            if (dsFill.Tables.Count > 0)
            {
                foreach (DataRow drLimit in dsFill.Tables[0].Rows)
                {
                    string clt = drLimit["party_code"].ToString();
                    var person = new Personlimit();
                    person.LoginId = "ADMIN";
                    person.ClientId = drLimit["party_code"].ToString();
                    person.CashMarginAvailable = Convert.ToInt32(drLimit["bsense"]);
                    //person.AdhocAll = Convert.ToInt32(drLimit["Adhoc_margin"]);
                    person.RMSSegment = 31;
                    person.RMSExchange = 31;
                    person.RMSProduct = 63;





                    var RMS_fields = new RMS_fieldslimit();
                    RMS_fields.LoginId = "ADMIN";
                    RMS_fields.ClientId = drLimit["party_code"].ToString();
                    RMS_fields.NotionalCash = Convert.ToInt32(drLimit["Notional_cash"]);
                    //RMS_fields.PayInAmout = 0;
                    //RMS_fields.PayOutAmout = 0;
                    RMS_fields.DirectCollatral = 0;
                    RMS_fields.AdhocAll = Convert.ToInt32(drLimit["Adhoc_margin"]);
                    //RMS_fields.AdhocAll = 0;
                    RMS_fields.AdhocCashNRML = 0;
                    RMS_fields.AdhocCashMIS = 0;
                    RMS_fields.AdhocFONRML = 0;
                    RMS_fields.AdhocFOMIS = 0;
                    RMS_fields.AdhocCURNRML = 0;
                    RMS_fields.AdhocCURMIS = 0;
                    RMS_fields.AdhocCOMNRML = 0;
                    RMS_fields.AdhocCOMMIS = 0;
                    RMS_fields.AdhocCashCNC = 0;
                    RMS_fields.IsIncrementValue = false;
                    RMS_fields.RMSSegment = 31;
                    RMS_fields.RMSExchange = 31;
                    RMS_fields.RMSProduct = 63;





                    System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                    System.Net.Http.HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                    HttpResponseMessage messge = client.PostAsync(URL, content).Result;
                    string description = string.Empty;
                    if (messge.IsSuccessStatusCode)
                    {
                        string description1 = string.Empty;
                        string resultP = messge.Content.ReadAsStringAsync().Result;
                        description1 = resultP;
                        clsResult cResult = JsonConvert.DeserializeObject<clsResult>(resultP);
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cResult.result.Token);
                        string URL_Limit_UAT = "https://algozy.rathi.com:3000/backofficeapi/balances/getbalance?source=WEB&userID=" + clt + "&accountID=" + clt;
                        HttpResponseMessage messge1 = client.GetAsync(URL_Limit_UAT).Result;
                        string descriptionPay = string.Empty;
                        string resultPay = messge1.Content.ReadAsStringAsync().Result;
                        descriptionPay = resultPay;
                        Rootobject abs = JsonConvert.DeserializeObject<Rootobject>(descriptionPay);
                        foreach (var item in abs.result.BalanceList)
                        {
                            RMS_fields.PayInAmout = Convert.ToInt32(item.limitObject.marginAvailable.PayInAmount);
                            RMS_fields.PayOutAmout = Convert.ToInt32(item.limitObject.marginAvailable.PayOutAmount);
                            if (drLimit["Type"].ToString() == "LMT")
                            {
                                RMS_fields.AdhocAll = Convert.ToInt32(drLimit["adhoc_margin"]); ;//+ 
                                RMS_fields.NotionalCash = Convert.ToInt32(item.limitObject.marginAvailable.NotinalCash);// + Convert.ToInt32(drLimit["Notional_Cash"]);
                                //RMS_fields.CashMarginAvailable = Convert.ToInt32(item.limitObject.marginAvailable.CashMarginAvailable);
                            }
                            else
                            {
                                RMS_fields.AdhocAll = Convert.ToInt32(item.limitObject.marginAvailable.AdhocMargin); ;//+ 
                            }
                        }
                        //////////////                             Updating Cash margin part
                        if (drLimit["Type"].ToString() == "INC")
                        {
                            person.LoginId = "ADMIN";
                            person.ClientId = drLimit["party_code"].ToString();
                            person.RMSSegment = 31;
                            person.RMSExchange = 31;
                            person.RMSProduct = 63;
                            var json = JsonConvert.SerializeObject(person);
                            var data = new StringContent(json, Encoding.UTF8, "application/json");
                            System.Net.Http.HttpClient clientlimit = new System.Net.Http.HttpClient();
                            System.Net.Http.HttpContent content1 = new StringContent(json, UTF8Encoding.UTF8, "application/json");
                            clientlimit.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cResult.result.Token);
                            HttpResponseMessage messgecash = clientlimit.PostAsync(URL_Limit, content1).Result;
                        }
                        //////////////                             Updating Notional part
                        var jsonnotional = JsonConvert.SerializeObject(RMS_fields);
                        System.Net.Http.HttpClient clientadhoc = new System.Net.Http.HttpClient();
                        System.Net.Http.HttpContent contentadhoc = new StringContent(jsonnotional, UTF8Encoding.UTF8, "application/json");
                        clientadhoc.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", cResult.result.Token);
                        HttpResponseMessage messgenotion = clientadhoc.PostAsync(URL_rms_fields, contentadhoc).Result;
                    }





                }







            }
        }
    }
}