// Как посмотреть содержимое папки?

void CatalogInfo(string path, string indent = "")
{
DirectoryInfo catalogs = new DirectoryInfo(path);
foreach (var currentCatalog in catalogs.GetDirectories())
{
Console.WriteLine($"{indent}{currentCatalog.Name}");
CatalogInfo(currentCatalog.FullName, indent + " ");
}
foreach (var item in catalogs.GetFiles())
{
Console.WriteLine($"{indent}{item.Name}");
}
}
string path = @"D:\XOPEK\8_Прочее\Java_II\1_Незавершенка\Знакомство с языком C#\Урок 7. 19.02.2023 Рекурсия продолжение\Less7\Ex_06_FoldersAndFiles";
CatalogInfo(path);
