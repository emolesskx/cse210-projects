public class CloudSync
{
    public static void SaveProfileToCloud(UserProfile profile)
    {
        string filePath = $"{profile.UserName}_data.txt";
        string encryptedData = EncryptData(profile);
        System.IO.File.WriteAllText(filePath, encryptedData);
    }

    public static UserProfile LoadProfileFromCloud(string userName)
    {
        string filePath = $"{userName}_data.txt";
        if (System.IO.File.Exists(filePath))
        {
            string encryptedData = System.IO.File.ReadAllText(filePath);
            return DecryptData(encryptedData);
        }
        return null;
    }

    private static string EncryptData(UserProfile profile)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(profile.UserName));
    }

    private static UserProfile DecryptData(string encryptedData)
    {
        string decodedData = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encryptedData));
        return new UserProfile(decodedData);
    }
}
