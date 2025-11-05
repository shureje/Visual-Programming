using System.Xml.Linq;
using System.Text;

namespace lab8
{
    public partial class Form1 : Form
    {
        private Button loadButton = null!;
        private RichTextBox contentTextBox = null!;
        private Label statusLabel = null!;
        private ProgressBar progressBar = null!;
        private const string RSS_URL = "http://lenta.ru/rss/articles";

        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadButton_Click(object? sender, EventArgs e)
        {
            loadButton.Enabled = false;
            progressBar.Visible = true;
            statusLabel.Text = "Загрузка RSS...";
            contentTextBox.Clear();

            try
            {
                await Task.Run(() => LoadRssFeed());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Ошибка загрузки";
            }
            finally
            {
                loadButton.Enabled = true;
                progressBar.Visible = false;
            }
        }

        private void LoadRssFeed()
        {
            try
            {
                XElement rootTag = XElement.Load(RSS_URL);
                var channel = rootTag.Element("channel");
                if (channel == null)
                {
                    throw new Exception("Неверный формат RSS");
                }

                var sb = new StringBuilder();

                sb.AppendLine("=== ИНФОРМАЦИЯ О КАНАЛЕ ===");
                sb.AppendLine($"Название: {channel.Element("title")?.Value ?? "Не указано"}");
                sb.AppendLine($"Описание: {channel.Element("description")?.Value ?? "Не указано"}");
                sb.AppendLine($"Ссылка: {channel.Element("link")?.Value ?? "Не указано"}");
                sb.AppendLine($"Язык: {channel.Element("language")?.Value ?? "Не указано"}");
                sb.AppendLine();

                var items = channel.Elements("item").ToList();
                sb.AppendLine($"=== СТАТЬИ ({items.Count}) ===");
                sb.AppendLine();

                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];

                    sb.AppendLine($"[{i + 1}] {item.Element("title")?.Value ?? "Без названия"}");
                    sb.AppendLine($"Автор: {item.Element("author")?.Value ?? "Не указан"}");
                    sb.AppendLine($"Категория: {item.Element("category")?.Value ?? "Не указана"}");
                    sb.AppendLine($"Дата: {item.Element("pubDate")?.Value ?? "Не указана"}");
                    sb.AppendLine($"Ссылка: {item.Element("link")?.Value ?? "Не указана"}");

                    var description = item.Element("description")?.Value;
                    if (!string.IsNullOrWhiteSpace(description))
                    {
                        description = description.Replace("<![CDATA[", "").Replace("]]", "");
                        description = System.Text.RegularExpressions.Regex.Replace(description, "<.*?>", "");
                        if (!string.IsNullOrWhiteSpace(description))
                        {
                            sb.AppendLine($"Описание: {description.Trim()}");
                        }
                    }

                    var enclosure = item.Element("enclosure");
                    if (enclosure != null)
                    {
                        sb.AppendLine($"Изображение: {enclosure.Attribute("url")?.Value ?? "Не указано"}");
                    }

                    sb.AppendLine(new string('-', 80));
                    sb.AppendLine();
                }

                this.Invoke(new Action(() =>
                {
                    contentTextBox.Text = sb.ToString();
                    statusLabel.Text = $"Загружено {items.Count} статей";
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    throw ex;
                }));
            }
        }

     
    }
}
