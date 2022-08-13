using JsonToVcard;
using JsonToVcard.Helpers;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

Root contacts = new(){list = new()};
using (StreamReader r = new StreamReader("result.json"))
{
    string json = r.ReadToEnd();
    contacts = JsonConvert.DeserializeObject<Root>(json);
}
string vcardcontents = "";
if (contacts != null)
{
    foreach (var contact in contacts.list)
    {
        vcardcontents += "\n"; 
        vcardcontents += FileHelper.CreateVCard(contact);
    }
}

string savePath = Path.Combine(AppContext.BaseDirectory, "output.vcf");
File.WriteAllText(savePath, vcardcontents);
Console.WriteLine("File saved at " + savePath.Trim());


Console.ReadKey();