using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
           
           
           
            
           
           
          

        
            Menu.ShowMainMenu();
            while (Menu.Input != Menu.ExitButton)
            {

                Menu.UserOption();

                switch (Menu.Input)
                {


                    case "1":

                        Menu.ShowTransportAddMenu();

                        while (Menu.Input != Menu.GoBackButton)
                        {
                            Menu.UserOption();
                            switch (Menu.Input)
                            {

                                case "1":
                                  
                                    Menu.CheckIfTaxiCanbeAdded();
                                   break;

                                    
                                case "2":

                                    Menu.CheckIfBusCanBeAdded();
                                    break;

                                case "N":

                                    Menu.ShowMainMenu();
                                    break;
                                case "X":

                                    Menu.ShowExitMessage();
                                    return;
                                default:

                                    Menu.ShowTransportAddMenu();
                                    Menu.InvalidOption();

                                    break;
                            }
                        }
                        
                        break;


                        case "2":

                        Menu.PrintTransportList();

                        break;

                        case "8":

                        Menu.ShowListDeleteMenu();
                        
                        while(Menu.Input != Menu.GoBackButton)
                        {
                            Menu.UserOption();
                            switch (Menu.Input)
                            {
                                case "1":
                                    
                                    Menu.DeleteAllVehicles();
                                    
                                    break;

                                case "N":
                                    Menu.ShowMainMenu();
                                    break;

                                default :

                                    Menu.ShowListDeleteMenu();
                                    Menu.InvalidOption();
                                    
                                    break;



                            }
                           
                        }
                        break;

                   


                    case "X":

                        Menu.ShowExitMessage();

                        break;

                    default:

                        Menu.ShowMainMenu();
                        Menu.InvalidOption();
                        break;


                }

            }







         

           


      


          
           
            





        }

     




    }
}
