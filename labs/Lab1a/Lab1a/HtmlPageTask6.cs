namespace Lab1a
{
    public class HtmlPageTask6
    {
        public static string GetHtmlPage()
        {
            return @"
            <!DOCTYPE html>
            <html>
            <body>
                <form method=""post"" action=""task5"">
                    <label for='x'>X:</label>
                    <input type='text' id='x' name='x'><br>

                    <label for='y'>Y:</label>
                    <input type='text' id='y' name='y'><br>

                    <input type='submit' value='Multiply' >
                </form>

                <div id='result'></div>
            </body>
            </html>";
        }
    }
}
