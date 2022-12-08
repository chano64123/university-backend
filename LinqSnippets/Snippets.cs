using System.Reflection.Metadata.Ecma335;

namespace LinqSnippets {
    public class Snippets {
        static public void BasicLinq() {
            string[] cars = { 
                "VM Golf",
                "VM California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat Leon"
            };

            //1. SELECT * OF CARS
            var carList = from car in cars select car;

            foreach(var car in carList) {
                Console.WriteLine(car);
            }

            //2. SELECT WHERE CAR IS AUDI
            var audiList = from car in cars where car.Contains("Audi") select car;

            foreach(var car in audiList) {
                Console.WriteLine(car);
            }
        }

        static public void LinqNumbers() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Each number multiply by 3
            //take all, but 9
            //Order umbers by ascending value

            var processedNumberList = numbers
                .Select(x => x * 3)
                .Where(x => x != 9)
                .OrderBy(x => x)
                .ToList();
        }
        static public void SearchExample() {
            List<string> textList = new List<string> {
                "a",
                "bx",
                "c",
                "d",
                "e",
                "cj",
                "f",
                "c"
            };

            //1. First of all elements
            var first = textList.First();

            //2. Fist element that has "c"
            var cText = textList.First(x => x.Equals("c"));

            //3. Fist element that constains "j"
            var jText = textList.First(x => x.Contains("j"));

            //4. Fist element that constains "z" or default
            var firstOrDefaultText = textList.FirstOrDefault(x => x.Contains("z"));

            //5. Last element that constains "z" or default
            var lastOrDefaultText = textList.LastOrDefault(x => x.Contains("z"));

            //6. String values
            var uniqueText = textList.Single();
            var uniqueOrDefaultText = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherEvenNumbers = { 0, 2, 6 };

            var myEvenNumbers = evenNumbers.Except(otherEvenNumbers);

        }

        static public void MultipleSlectors() {
            string[] myOpinions = { 
                "Opinion 1, text 1",
                "Opinion 2, text 2",
                "Opinion 3, text 3"
            };

            var myOpinionsSelection = myOpinions.SelectMany(x => x.Split(","));

            var enterprises = new[] {
                new Enterprise() {
                    id= 1,
                    name = "Enterprise 1",
                    employees = new[] {
                        new Employee() {
                            id= 1,
                            name="Martin",
                            email = "martin@gmail.com",
                            salary = 2500
                        },
                        new Employee() {
                            id= 2,
                            name="Jose",
                            email = "jose@gmail.com",
                            salary = 1900
                        },
                        new Employee() {
                            id= 3,
                            name="Juan",
                            email = "juan@gmail.com",
                            salary = 5000
                        },
                    }
                },
                new Enterprise() {
                    id= 2,
                    name = "Enterprise 2",
                    employees = new[] {
                        new Employee() {
                            id= 5,
                            name="Andrea",
                            email = "andrea@gmail.com",
                            salary = 3000
                        },
                        new Employee() {
                            id= 5,
                            name="Martha",
                            email = "martha@gmail.com",
                            salary = 2300
                        },
                        new Employee() {
                            id= 6,
                            name="Maria",
                            email = "maria@gmail.com",
                            salary = 4000
                        },
                    }
                }
            };

            //obtain all empleyes of all enterprtises
            var employeList = enterprises.SelectMany(x => x.employees);

            //know if an a list is empty
            bool hasEnterprises = enterprises.Any();

            bool hasEmployes = enterprises.Any(x => x.employees.Any());

            //All enterprise at leas has an employee an employee with nmora than 1000 salary
            bool hasEmployesWhitSalaryThaOrEqual1000 = enterprises.Any(x => x.employees.Any(y => y.salary >= 1000));

        }

        static public void linqConnections() {
            var firstList = new List<string>() { "a", "b", "c" };
            var secondList = new List<string>() { "a", "c", "d" };

            //INNER JOIN
            var commonResult = from element in firstList
                               join secondElement in secondList
                               on element equals secondElement
                               select new { element, secondElement };

            var commonResult2 = firstList.Join(
                    secondList, 
                    element => element,
                    secondElement => secondElement,
                    (element, secondElement) => new {element, secondElement}
                );

            //OUTER JOIN - LEFT
            var leftOuterJoin = from element in firstList
                                join secondElement in secondList
                                on element equals secondElement
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where element != temporalElement
                                select new { Element = element };

            var leftOuterJoin2 = from element in firstList
                                 from secondElement in secondList.Where(x => x == element).DefaultIfEmpty()
                                 select new { Element = element, SecondElement = secondElement};


            //OUTER JOIN - RIGHT
            var rightOuterJoin = from secondElement in secondList
                                 join element in firstList
                                 on secondElement equals element
                                 into temporalList
                                 from temporalElement in temporalList.DefaultIfEmpty()
                                 where secondElement != temporalElement
                                 select new { Element = secondElement };

            //UNION
            var unionList = leftOuterJoin.Union(rightOuterJoin);
        }

        static public void SkipTakeLinq() {
            var myList = new[] {
                1, 2, 3, 4,, 5, 6, 7, 8, 9, 10
            };

            //SKIP
            var skipTwoFirstElements = myList.Skip(2);
            var skipTwoLastElements = myList.SkipLast(2);
            var skipWhileSmallerThan4 = myList.SkipWhile(x => x < 4);

            //TAKE
            var takeTwoFirstElements = myList.Take(2);
            var takeTwoLastElements = myList.TakeLast(2);
            var takeWhileSmallerThan4 = myList.TakeWhile(x => x < 4);


        }
    }
}