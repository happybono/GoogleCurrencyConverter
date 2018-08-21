Imports System.Text.RegularExpressions

Public Class FrmCurrency

    Public countryCode() As String = {"AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BMD", "BND", "BOB", "BRL", "BSD", "BTC", "BTN", "BWP", "BYN", "BYR", "BZD", "CAD", "CDF", "CHF", "CLF", "CLP", "CNH", "CNY", "COP", "CRC", "CUP", "CVE", "CZK", "DEM", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "FIM", "FJD", "FKP", "FRF", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "GYD", "HKD", "HNL", "HRK", "HTG", "HUF", "IDR", "IEP", "ILS", "INR", "IQD", "IRR", "ISK", "ITL", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LVL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MUR", "MVR", "MWK", "MXN", "MYR", "MZN", "NAD", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKG", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SHP", "SKK", "SLL", "SOS", "SRD", "STD", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "UYU", "UZS", "VEF", "VND", "VUV", "WST", "XAF", "XCD", "XDR", "XOF", "XPF", "YER", "ZAR", "ZMK", "ZMW", "ZWL"}

    Public Function Convert(ByVal amount As Decimal, ByVal fromCurrency As String, ByVal toCurrency As String) As Decimal
        Dim web As System.Net.WebClient = New System.Net.WebClient()
        Dim url As String = String.Format("https://finance.google.com/finance/converter?a={2}&from={0}&to={1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount)
        Dim response As String = web.DownloadString(url)

        Dim matchString As String = Regex.Match(response, "(d>\d*(\.\d*|) |Could Not Convert\.)").Value
        matchString = matchString.Substring(2, matchString.Length - 2)

        Dim rate As Decimal = System.Convert.ToDecimal(matchString)
        Return rate
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim country1 As String
        Dim country2 As String

        country1 = countryCode(ComboBox1.SelectedIndex)
        country2 = countryCode(ComboBox2.SelectedIndex)

        Label1.Text = (Convert(Val(TextBox1.Text), country1, country2)) & " " & country2
        ToolStripStatusLabel2.Text = "1" & " " & country1.ToString & " = " & Math.Round((Convert(1, country1, country2)), 2) & " " & country2
        ToolStripStatusLabel1.Text = "최종 업데이트" & " : " & Now.ToShortDateString & " " & Now.ToShortTimeString
    End Sub

    Public Sub GetAllRates(ByVal rateCurrency As String)
        Dim allrates() As Decimal = {}

        For Each curCountryCode As String In countryCode
            allrates(curCountryCode) = Val(Convert(1, rateCurrency, curCountryCode))
        Next
    End Sub

    Private Sub FrmCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = String.Empty
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        GetAllRates(countryCode(ComboBox1.Items.Count))
        MsgBox("done")
    End Sub
End Class