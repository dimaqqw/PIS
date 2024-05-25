namespace Lab1a
{
    public class HtmlPageTask5
    {
        public static string GetHtmlPage()
        {
            return @"
            <!DOCTYPE html>
            <html>
            <body>
                <form>
                    <label for='x'>X:</label>
                    <input type='text' id='x' name='x'><br>

                    <label for='y'>Y:</label>
                    <input type='text' id='y' name='y'><br><br>

                    <input type='button' value='result' onclick='multiply()'>
                </form>
                <div id=""result""></div>

                <script>
                    function multiply() {
                        const x = document.getElementById('x').value;
                        const y = document.getElementById('y').value;
                        var xhr = new XMLHttpRequest();
                        xhr.open('POST', '/task5', true);
                        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
                        xhr.onreadystatechange = function () {
                            if (xhr.readyState !== XMLHttpRequest.DONE) return;
                            var h1Element = document.getElementById('result');
                            h1Element.textContent = ""Result: "" + xhr.responseText;
                        }
                        xhr.send('x=' + encodeURIComponent(x) + '&y=' + encodeURIComponent(y));
                    }
                </script>
            </body>
            </html>";
        }
    }
}
