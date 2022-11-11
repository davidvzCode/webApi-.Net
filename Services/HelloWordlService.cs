namespace webApi.Services
{
    public class HelloWordlService: IHelloWordlService
    {
        public string GetHelloWordl()
        {
            return "Hello Wordl";
        }
    }
}


public interface IHelloWordlService{
    string GetHelloWordl();
}