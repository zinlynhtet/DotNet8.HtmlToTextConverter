using System.Text.RegularExpressions;

string htmlContent = "<p>Hello <b>World!</b></p>";
string plainText = ExtractTextFromHtml(htmlContent);
Console.WriteLine(plainText); 
string ExtractTextFromHtml(string html)
{
    if (html is null)
    {
        return "";
    }

    string plainText = Regex.Replace(html, "<[^>]+?>", " ");
    plainText = System.Net.WebUtility.HtmlDecode(plainText).Trim();

    return plainText;
}