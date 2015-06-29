using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.FactoryMethod
{
    public class FactoryMethodSample
    {

        public static void Run()
        {

            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();

        }
    }

    public abstract class Page
    {

        public Page()
        {
            Console.WriteLine("Inside Page");
        }
    }

    public class SkillPage : Page
    {
        public SkillPage
            (): base()
        {
            Console.WriteLine("Skill Page");
        }
    }


    public class EducationPage : Page
    {
        public EducationPage() : base()
        {
            Console.WriteLine("Education Page");
        }
    }


    
    public class ExperiencePage : Page
    {
        public ExperiencePage() : base()
        {
            Console.WriteLine("Experience Page");
        }
    }


/// <summary>
/// 
/// </summary>
    public class IntroductionPage : Page
    {
        public IntroductionPage() : base()
        {
            Console.WriteLine("Introduction Page");
        }
    }


            /// <summary>
          /// A 'ConcreteProduct' class
          /// </summary>
          public class ResultsPage : Page
          {
          }
 
          /// <summary>
          /// A 'ConcreteProduct' class
          /// </summary>
          public class ConclusionPage : Page
          {
          }
 
          /// <summary>
          /// A 'ConcreteProduct' class
          /// </summary>
          public class SummaryPage : Page
          {
          }
 
          /// <summary>
          /// A 'ConcreteProduct' class
          /// </summary>
          public class BibliographyPage : Page
          {
          }


    public abstract class Document
    {

        public List<Page> pages = new List<Page>();
        public Document()
        {

        }

        public  List<Page> Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }

        public abstract void CreatePages();
        
    }


    public class Resume : Document
    {

        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
