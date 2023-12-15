namespace Assignment2;

class PhotoBook
{
    private protected int _numPages;

    public PhotoBook()
    {
        _numPages = 16;
    }

    public PhotoBook(int pages)
    {
        _numPages = pages;
    }

    public int GetNumberPages()
    {
        return _numPages;
    }

}

class BigPhotoBook : PhotoBook
{

    public BigPhotoBook()
    {
        _numPages = 64;
    }
}

static class PhotoBookTest
{
    static void Main()
    {
        PhotoBook photobook_def = new PhotoBook();
        Console.WriteLine(photobook_def.GetNumberPages());
        PhotoBook photobook_24 = new PhotoBook(24);
        Console.WriteLine(photobook_24.GetNumberPages());
        BigPhotoBook photobook_big = new BigPhotoBook();
        Console.WriteLine(photobook_big.GetNumberPages());
    }
}