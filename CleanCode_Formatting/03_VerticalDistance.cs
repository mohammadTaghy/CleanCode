using CleanCode_Formatting;
using CleanCode_MeaningfulNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_Formatting
{
    //Variable Declarations
    class Sample
    {
        static int x = 10; // A global variable with a meaningless name
        static void Main(string[] args)
        {
            int a; // A local variable declared far from its usage
            string b = "Hello"; // A local variable with an unclear name
            Console.WriteLine(b + " World!"); // A literal value that could be a constant
            a = x * 2; // A magic number that could be a constant
            Console.WriteLine(a);
        }
    }
    class Sample_Clean
    {
        const string Greeting = "Hello"; // A constant with a descriptive name

        static void Main(string[] args)
        {
            int result = GetResult(); // A local variable with a meaningful name and close to its usage
            Console.WriteLine(Greeting + " World!"); // Using constants instead of literal values
            Console.WriteLine(result);
        }

        const int Multiplier = 2; // A constant with a descriptive name

        static int GetResult()
        {
            int input = 10; // A local variable with a meaningful name and close to its usage
            return input * Multiplier; // Using constants instead of magic numbers
        }
    }
    // Instance variables
    public class Person
    {
        // Instance variables
        private string name;
        private int age;

        // A constructor that initializes the instance variables
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // A method that returns the name of the person
        public string GetName()
        {
            return name;
        }

        // A method that returns the age of the person
        public int GetAge()
        {
            return age;
        }
    }

    //Dependent function
    // A class that represents a calculator
    public class WikiPageResponder
    {
        protected WikiPage page;
        protected PageData pageData;
        protected String pageTitle;
        protected Request request;
        protected PageCrawler crawler;
        public Response makeResponse(FitNesseContext context, Request request)
        {
            String pageName = getPageNameOrDefault(request, "FrontPage");
            loadPage(pageName, context);
            if (page == null)
                return notFoundResponse(context, request);
            else
                return makePageResponse(context);
        }

        private String getPageNameOrDefault(Request request, String defaultPageName)
        {
            String pageName = request.getResource();
            if (StringUtil.isBlank(pageName))
                pageName = defaultPageName;
            return pageName;
        }

        protected void loadPage(String resource, FitNesseContext context)
        {
            WikiPagePath path = PathParser.parse(resource);
            crawler = context.root.getPageCrawler();
            crawler.setDeadEndStrategy(new VirtualEnabledPageCrawler());
            page = crawler.getPage(context.root, path);
            if (page != null)
                pageData = page.getData();
        }

        private Response notFoundResponse(FitNesseContext context, Request request)
        {
            return new NotFoundResponder().makeResponse(context, request);
        }

        private SimpleResponse makePageResponse(FitNesseContext context)
        {
            pageTitle = PathParser.render(crawler.getFullPath(page));
            String html = makeHtml(context);
            SimpleResponse response = new SimpleResponse();
            response.setMaxAge(0);
            response.setContent(html);
            return response;
        }

    }
    //Conceptual Affinity
    public class Assert
    {
        static public void assertTrue(String message, boolean condition)
        {
            if (!condition)
                fail(message);
        }
        static public void assertTrue(boolean condition)
        {
            assertTrue(null, condition);
        }
        static public void assertFalse(String message, boolean condition)
        {
            assertTrue(message, !condition);
        }
        static public void assertFalse(boolean condition)
        {
            assertFalse(null, condition);
        }
    }
}
