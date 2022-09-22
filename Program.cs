int ticket10 = 0, ticket20 = 0, ticket30 = 0;
int sellAmount10=0, sellAmount20=0, sellAmount30=0;
bool working = true;

while (working)
{
    Console.WriteLine("Meniu: [1] Pirkti bilietus, [2] Kurti bilietus, [3] Ataskaita, [4] Iseiti");
    int input = int.Parse(Console.ReadLine());

    switch(input)
    {
        case 1:
            {
                if(ticket10!=0 || ticket20!=0 || ticket30!=0)
                {
                    Console.WriteLine($"Turimi bilietai: 10eur-{ticket10}vnt, 20eur-{ticket20}vnt, 30eur- {ticket30}vnt");
                    Console.WriteLine("Koki bilieta pirksit: [1] 10euru, [2] 20euru, [3] 30euru ");
                    int ticketPrice = int.Parse(Console.ReadLine());

                    switch(ticketPrice)
                    {
                        case 1:
                            {
                                if (ticket10!=0)
                                {
                                    SellTickets10();
                                }
                                else
                                {
                                    Console.WriteLine("Bilietu po 10eur neturime.");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (ticket20 != 0)
                                {
                                    SellTickets20();
                                }
                                else
                                {
                                    Console.WriteLine("Bilietu po 20eur neturime.");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (ticket30 != 0)
                                {
                                    SellTickets30();
                                }
                                else
                                {
                                    Console.WriteLine("Bilietu po 30eur neturime.");
                                }
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Siuo metu bilietu neturime.");
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Kokius bilietus norite kurti: ");
                Console.WriteLine("[1] 10euru, [2] 20euru, [3] 30euru ");
                int createTicket = int.Parse(Console.ReadLine());

                switch(createTicket)
                {
                    case 1:
                        {
                            CreateTickets10();
                            break; 
                        }
                    case 2:
                        {
                           CreateTickets20();
                            break;
                        }
                    case 3:
                        {
                            CreateTickets30();
                            break;
                        }
                }

                break;
            }
        case 3:
            {
                TotalSell();
                Console.WriteLine($"Parduota po 10eur: {sellAmount10}");
                Console.WriteLine($"Parduota po 20eur: {sellAmount20}");
                Console.WriteLine($"Parduota po 20eur: {sellAmount30}");
                TotalFree();
                Console.WriteLine($"Liko po 10eur: {ticket10}");
                Console.WriteLine($"Liko po 20eur: {ticket20}");
                Console.WriteLine($"Liko po 30eur: {ticket30}");
                TotalCreated();
                Console.WriteLine($"Sukurta po 10eur: {ticket10 + sellAmount10}");
                Console.WriteLine($"Sukurta po 20eur: {ticket20 + sellAmount20}");
                Console.WriteLine($"Sukurta po 30eur: {ticket30 + sellAmount30}");
                break;
            }

        case 4:
            {
                Console.WriteLine("Viso gero!");
                working = false;
                break;
            }
    }

}

int CreateTickets10()
{
    Console.WriteLine("Kiek noresite sukurti bilietu po 10eur?");
    ticket10 = int.Parse(Console.ReadLine());
    return ticket10;
}
int CreateTickets20()
{
    Console.WriteLine("Kiek noresite sukurti bilietu po 20eur?");
    ticket20 = int.Parse(Console.ReadLine());
    return ticket20;
}
int CreateTickets30()
{
    Console.WriteLine("Kiek noresite sukurti bilietu po 30eur?");
    ticket30 = int.Parse(Console.ReadLine());
    return ticket30;
}
int SellTickets10()
{
    Console.WriteLine("Pasirinkti bilietai po 10eur. Kiek bilietu pirksite?");
    sellAmount10 = int.Parse(Console.ReadLine());
    ticket10 -= sellAmount10;
    return sellAmount10;
}
int SellTickets20()
{
    Console.WriteLine("Pasirinkti bilietai po 20eur. Kiek bilietu pirksite?");
    sellAmount20 = int.Parse(Console.ReadLine());
    ticket20 -= sellAmount20;
    return sellAmount20;
}
int SellTickets30()
{
    Console.WriteLine("Pasirinkti bilietai po 30eur. Kiek bilietu pirksite?");
    sellAmount30 = int.Parse(Console.ReadLine());
    ticket30 -= sellAmount30;
    return sellAmount30;
}
int TotalCreated()
{
    int totalCreated = (ticket10 + sellAmount10) + (ticket20 + sellAmount20) + (ticket30 + sellAmount30);
    Console.WriteLine($"Viso sukurta bilietu:{totalCreated}");
    return totalCreated;
}
int TotalSell()
{
    int totalSell= sellAmount10 + sellAmount20 + sellAmount30;
    Console.WriteLine($"Viso parduota bilietu:{totalSell}");
    return totalSell;
}
int TotalFree()
{
    int totalFree = ticket10 + ticket20 + ticket30;
    Console.WriteLine($"Viso likusiu bilietu:{totalFree}");
    return totalFree;
}
