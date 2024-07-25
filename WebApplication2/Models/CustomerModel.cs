using Newtonsoft.Json;

namespace WebApplication2.Models
{
    public class CustomerModel
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }

        public List<Value> value { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.etag")]
        public string odataetag { get; set; }

        public string No { get; set; }
        public string Name { get; set; }
        public string CFDI_Customer_Name { get; set; }
        public string Name_2 { get; set; }
        public string Search_Name { get; set; }
        public string IC_Partner_Code { get; set; }
        public double Balance_LCY { get; set; }
        public int BalanceAsVendor { get; set; }
        public double Balance_Due_LCY { get; set; }
        public int Credit_Limit_LCY { get; set; }
        public string Blocked { get; set; }
        public bool Privacy_Blocked { get; set; }
        public int CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string Salesperson_Code { get; set; }
        public string Responsibility_Center { get; set; }
        public string Service_Zone_Code { get; set; }
        public string Document_Sending_Profile { get; set; }
        public double TotalSales2 { get; set; }
        public double CustSalesLCY_CustProfit_AdjmtCostLCY { get; set; }
        public double AdjCustProfit { get; set; }
        public double AdjProfitPct { get; set; }
        public string CFDI_Purpose { get; set; }
        public string CFDI_Relation { get; set; }
        public string CFDI_Export_Code { get; set; }
        public string SAT_Tax_Regime_Classification { get; set; }
        public bool CFDI_General_Public { get; set; }
        public string CFDI_Period { get; set; }
        public string Last_Date_Modified { get; set; }
        public bool Disable_Search_by_Name { get; set; }
        public int Priority { get; set; }
        public string Address { get; set; }
        public string Address_2 { get; set; }
        public string Country_Region_Code { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Post_Code { get; set; }
        public string ShowMap { get; set; }
        public string Phone_No { get; set; }
        public string MobilePhoneNo { get; set; }
        public string E_Mail { get; set; }
        public string Fax_No { get; set; }
        public string Home_Page { get; set; }
        public string Language_Code { get; set; }
        public string Format_Region { get; set; }
        public string Primary_Contact_No { get; set; }
        public string ContactName { get; set; }
        public string Bill_to_Customer_No { get; set; }
        public string VAT_Registration_No { get; set; }
        public string EORI_Number { get; set; }
        public string GLN { get; set; }
        public bool Use_GLN_in_Electronic_Document { get; set; }
        public string Copy_Sell_to_Addr_to_Qte_From { get; set; }
        public bool Tax_Liable { get; set; }
        public string Tax_Area_Code { get; set; }
        public string Tax_Identification_Type { get; set; }
        public string Tax_Exemption_No { get; set; }
        public string RFC_No { get; set; }
        public string CURP_No { get; set; }
        public string State_Inscription { get; set; }
        public string Registration_Number { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string VAT_Bus_Posting_Group { get; set; }
        public string Customer_Posting_Group { get; set; }
        public bool Allow_Multiple_Posting_Groups { get; set; }
        public string Currency_Code { get; set; }
        public string Price_Calculation_Method { get; set; }
        public string Customer_Price_Group { get; set; }
        public string Customer_Disc_Group { get; set; }
        public bool Allow_Line_Disc { get; set; }
        public string Invoice_Disc_Code { get; set; }
        public bool Prices_Including_VAT { get; set; }
        public int Prepayment_Percent { get; set; }
        public string Application_Method { get; set; }
        public string Partner_Type { get; set; }
        public string Intrastat_Partner_Type { get; set; }
        public string Payment_Terms_Code { get; set; }
        public string Payment_Method_Code { get; set; }
        public string Reminder_Terms_Code { get; set; }
        public string Fin_Charge_Terms_Code { get; set; }
        public string Cash_Flow_Payment_Terms_Code { get; set; }
        public bool Print_Statements { get; set; }
        public int Last_Statement_No { get; set; }
        public bool Block_Payment_Tolerance { get; set; }
        public string Preferred_Bank_Account_Code { get; set; }
        public string Bank_Communication { get; set; }
        public string Check_Date_Format { get; set; }
        public string Check_Date_Separator { get; set; }
        public bool Exclude_from_Pmt_Practices { get; set; }
        public string Ship_to_Code { get; set; }
        public string Location_Code { get; set; }
        public bool Combine_Shipments { get; set; }
        public string Reserve { get; set; }
        public string Shipping_Advice { get; set; }
        public string Shipment_Method_Code { get; set; }
        public string Shipping_Agent_Code { get; set; }
        public string Shipping_Agent_Service_Code { get; set; }
        public string Shipping_Time { get; set; }
        public string Base_Calendar_Code { get; set; }
        public string Customized_Calendar { get; set; }
        public double Balance_LCY_2 { get; set; }
        public int ExpectedCustMoneyOwed { get; set; }
        public int TotalMoneyOwed { get; set; }
        public int CreditLimit { get; set; }
        public int CalcCreditLimitLCYExpendedPct { get; set; }
        public int Balance_Due { get; set; }
        public double Payments_LCY { get; set; }
        public int CustomerMgt_AvgDaysToPay_No { get; set; }
        public int DaysPaidPastDueDate { get; set; }
        public int AmountOnPostedInvoices { get; set; }
        public int AmountOnCrMemo { get; set; }
        public int AmountOnOutstandingInvoices { get; set; }
        public int AmountOnOutstandingCrMemos { get; set; }
        public int Totals { get; set; }
        public int CustInvDiscAmountLCY { get; set; }
        public string Global_Dimension_1_Filter { get; set; }
        public string Global_Dimension_2_Filter { get; set; }
        public string Currency_Filter { get; set; }
        public string Date_Filter { get; set; }
    }

    public class CustomerInput
    {
        public string Name { get; set; }
        public string No { get; set; }
    }

    public class CustomerOutputModel
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }

        [JsonProperty("@odata.etag")]
        public string odataetag { get; set; }

        public string No { get; set; }
        public string Name { get; set; }
        public string CFDI_Customer_Name { get; set; }
        public string Name_2 { get; set; }
        public string Search_Name { get; set; }
        public string IC_Partner_Code { get; set; }
        public int Balance_LCY { get; set; }
        public int BalanceAsVendor { get; set; }
        public int Balance_Due_LCY { get; set; }
        public int Credit_Limit_LCY { get; set; }
        public string Blocked { get; set; }
        public bool Privacy_Blocked { get; set; }
        public int CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string Salesperson_Code { get; set; }
        public string Responsibility_Center { get; set; }
        public string Service_Zone_Code { get; set; }
        public string Document_Sending_Profile { get; set; }
        public int TotalSales2 { get; set; }
        public int CustSalesLCY_CustProfit_AdjmtCostLCY { get; set; }
        public int AdjCustProfit { get; set; }
        public int AdjProfitPct { get; set; }
        public string CFDI_Purpose { get; set; }
        public string CFDI_Relation { get; set; }
        public string CFDI_Export_Code { get; set; }
        public string SAT_Tax_Regime_Classification { get; set; }
        public bool CFDI_General_Public { get; set; }
        public string CFDI_Period { get; set; }
        public string Last_Date_Modified { get; set; }
        public bool Disable_Search_by_Name { get; set; }
        public int Priority { get; set; }
        public string Address { get; set; }
        public string Address_2 { get; set; }
        public string Country_Region_Code { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Post_Code { get; set; }
        public string ShowMap { get; set; }
        public string Phone_No { get; set; }
        public string MobilePhoneNo { get; set; }
        public string E_Mail { get; set; }
        public string Fax_No { get; set; }
        public string Home_Page { get; set; }
        public string Language_Code { get; set; }
        public string Format_Region { get; set; }
        public string Primary_Contact_No { get; set; }
        public string ContactName { get; set; }
        public string Bill_to_Customer_No { get; set; }
        public string VAT_Registration_No { get; set; }
        public string EORI_Number { get; set; }
        public string GLN { get; set; }
        public bool Use_GLN_in_Electronic_Document { get; set; }
        public string Copy_Sell_to_Addr_to_Qte_From { get; set; }
        public bool Tax_Liable { get; set; }
        public string Tax_Area_Code { get; set; }
        public string Tax_Identification_Type { get; set; }
        public string Tax_Exemption_No { get; set; }
        public string RFC_No { get; set; }
        public string CURP_No { get; set; }
        public string State_Inscription { get; set; }
        public string Registration_Number { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string VAT_Bus_Posting_Group { get; set; }
        public string Customer_Posting_Group { get; set; }
        public bool Allow_Multiple_Posting_Groups { get; set; }
        public string Currency_Code { get; set; }
        public string Price_Calculation_Method { get; set; }
        public string Customer_Price_Group { get; set; }
        public string Customer_Disc_Group { get; set; }
        public bool Allow_Line_Disc { get; set; }
        public string Invoice_Disc_Code { get; set; }
        public bool Prices_Including_VAT { get; set; }
        public int Prepayment_Percent { get; set; }
        public string Application_Method { get; set; }
        public string Partner_Type { get; set; }
        public string Intrastat_Partner_Type { get; set; }
        public string Payment_Terms_Code { get; set; }
        public string Payment_Method_Code { get; set; }
        public string Reminder_Terms_Code { get; set; }
        public string Fin_Charge_Terms_Code { get; set; }
        public string Cash_Flow_Payment_Terms_Code { get; set; }
        public bool Print_Statements { get; set; }
        public int Last_Statement_No { get; set; }
        public bool Block_Payment_Tolerance { get; set; }
        public string Preferred_Bank_Account_Code { get; set; }
        public string Bank_Communication { get; set; }
        public string Check_Date_Format { get; set; }
        public string Check_Date_Separator { get; set; }
        public bool Exclude_from_Pmt_Practices { get; set; }
        public string Ship_to_Code { get; set; }
        public string Location_Code { get; set; }
        public bool Combine_Shipments { get; set; }
        public string Reserve { get; set; }
        public string Shipping_Advice { get; set; }
        public string Shipment_Method_Code { get; set; }
        public string Shipping_Agent_Code { get; set; }
        public string Shipping_Agent_Service_Code { get; set; }
        public string Shipping_Time { get; set; }
        public string Base_Calendar_Code { get; set; }
        public string Customized_Calendar { get; set; }
        public int Balance_LCY_2 { get; set; }
        public int ExpectedCustMoneyOwed { get; set; }
        public int TotalMoneyOwed { get; set; }
        public int CreditLimit { get; set; }
        public int CalcCreditLimitLCYExpendedPct { get; set; }
        public int Balance_Due { get; set; }
        public int Payments_LCY { get; set; }
        public int CustomerMgt_AvgDaysToPay_No { get; set; }
        public int DaysPaidPastDueDate { get; set; }
        public int AmountOnPostedInvoices { get; set; }
        public int AmountOnCrMemo { get; set; }
        public int AmountOnOutstandingInvoices { get; set; }
        public int AmountOnOutstandingCrMemos { get; set; }
        public int Totals { get; set; }
        public int CustInvDiscAmountLCY { get; set; }
        public string Global_Dimension_1_Filter { get; set; }
        public string Global_Dimension_2_Filter { get; set; }
        public string Currency_Filter { get; set; }
        public string Date_Filter { get; set; }
    }
}