// Task 1 to 7
enum ArticleType
{
    TEA,
    SUGAR,
    CHOCOLATE,
    APPLE,
    BANANA
}

enum ClientType
{
    SPECIAL,
    DEFAULT,
    VIP
}

enum PayType
{
    DEBITCARD,
    CREDITCARD,
    CASH
}

struct Article
{
    string _code;
    string _name;
    double _price;

    public Article(string code, string name, double price)
    {
        _code = code;
        _name = name;
        _price = price;
    }
}

struct Client
{
    string _code;
    string _fullName;
    string _lastName;
    string _address;
    string _telephone;
    int _order_amount;
    int _product_price;

    public Client(string code, string fullName, string lastName, string address, string telephone, int order_amount, int product_price)
    {
        _code = code;
        _fullName = fullName;
        _lastName = lastName;
        _address = address;
        _telephone = telephone;
        _order_amount = order_amount;
        _product_price = product_price;
    }
}

struct RequestItem
{
    string _commodity;
    int _commodity_count;

    public RequestItem(string commodity, int commodity_count)
    {
        _commodity = commodity;
        _commodity_count = commodity_count;
    }
}

struct Request
{
    string _order_code;
    string _client;
    string _order_date;
    string[] _list;
    double _order_price;

    public Request(string order_code, string client, string order_date, string[] list, double order_price)
    {
        _order_code = order_code;
        _client = client;
        _order_date = order_date;
        _list = new string[list.Length];
        _order_price = order_price;
    }
}
