using System.Text;

namespace JsonToVcard.Helpers;

public static class FileHelper
{
    const string NewLine = "\r\n";
    const string Separator = ";";
    const string Header = "BEGIN:VCARD\r\nVERSION:3.0";
    const string FormattedName = "FN:";
    const string Name = "N:";
    const string PhonePrefix = "TEL;TYPE=Home";
    const string PhoneSubPrefix = ",VOICE:";
    const string Footer = "END:VCARD";
    public static string CreateVCard(List contact)
    {
        StringBuilder fw = new StringBuilder();
        fw.Append(Header);
        fw.Append(NewLine);

        //Full Name
        if (!string.IsNullOrEmpty(contact.first_name) || !string.IsNullOrEmpty(contact.last_name))
        {
            fw.Append(Name);
            fw.Append(contact.last_name);
            fw.Append(Separator);
            fw.Append(contact.first_name);
            fw.Append(Separator);
            fw.Append(NewLine);
            
            fw.Append(FormattedName);
            fw.Append(contact.first_name + " " + contact.last_name);
            fw.Append(NewLine);
        }

        


        //Phones
        
        if (!string.IsNullOrEmpty(contact.phone_number))
        {
            fw.Append(PhonePrefix);
            fw.Append(PhoneSubPrefix);
            fw.Append(contact.phone_number);
            fw.Append(NewLine);
        }
        fw.Append(Footer);

        return fw.ToString();
    }
}