using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "---");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Product Class
        /// </summary>
        abstract class Page{}

        /// <summary>
        /// A Concrete Product
        /// </summary>
        class SkillPage : Page { }

        /// <summary>
        /// A Concrete Product
        /// </summary>
        class EducationPage: Page { }
        /// <summary>
        /// A Concrete Product
        /// </summary>
        class ExperiencePage : Page { }
        /// <summary>
        /// A Concrete Product
        /// </summary>
        class IntroductionPage : Page{ }

        /// <summary>
        /// A Concrete Product
        /// </summary>
        class ResultsPage : Page { }
        /// <summary>
        /// A Concrete Product
        /// </summary>
        class BibliographyPage : Page { }



        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        class SummaryPage : Page{}

        /// <summary>
        /// A 'ConcreteProduct' class
        /// </summary>
        class ConclusionPage : Page{}

        /// <summary>
        /// Creator abstract class
        /// </summary>
        abstract class Document
        {
            private List<Page> _pages = new List<Page>();
            public Document(){
                this.CreatePages();
            }

            public List<Page> Pages
            {
                get {
                    return _pages;
                }
            }

            public abstract void CreatePages();
        }

        /// <summary>
        /// Concretor Classs
        /// </summary>
        class Resume : Document
        {
            public override void CreatePages()
            {
                Pages.Add(new SkillPage());
                Pages.Add(new EducationPage());
                Pages.Add(new ExperiencePage());
            }
        }
        /// <summary>
        /// Concretor Classs
        /// </summary>
        class Report : Document
        {
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
}
