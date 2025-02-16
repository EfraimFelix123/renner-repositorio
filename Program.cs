using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;


namespace Efraim
{
public class HelloWorld
{    public static void Helloworld()
    {
        Console.WriteLine("Hello World!");
    } 
}
public class Final{
public int apoios;
public void ApoioRenner()
{
    
  
 PirokudosVivo();
}
public void PirokudosVivo()
{
Console.Clear();
Final apoira = new Final();
void apoiorenner (){
 apoiorenner:
   Console.Clear();
         Console.ForegroundColor = ConsoleColor.Yellow;
         string [] apoio = {"1.VOCÊ CONSEGUE, CAUÃN RENNER!","2.NAO DESISTA, CAUÃN RENNER!","3.MAIS UM POUCO, CAUÃN RENNER!","4.VOCÊ É TUDO, CAUÃN RENNER!",};
         foreach(var apoiar in apoio)
         {
Console.WriteLine(apoiar);
         }
      
           Console.ResetColor();
Console.Write("Escolha uma opção: ");
int escolha = int.Parse(Console.ReadLine());

if (escolha == 1)
{
    Console.Clear();
   Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("VOCÊ CONSEGUE, CAUÃN RENNER!");
        Console.ResetColor();
        Console.ReadKey();

Console.ReadKey();
} else if (escolha == 2)
{
    Console.Clear();
 Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("NÃO DESISTA, CAUÃN RENNER!");
           Console.ResetColor();
           Console.ReadKey();
           
Console.ReadKey();

}
 
else if (escolha == 3)
{ 
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("MAIS UM POUCO, CAUÃN RENNER!");
           Console.ResetColor();
           Console.ReadKey();
        
Console.ReadKey();
} else if (escolha == 4)
{ 
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("VOCÊ É TUDO, CAUÃN RENNER!");
           Console.ResetColor();
           Console.ReadKey();
           
Console.ReadKey();
      
} else 
{

    
goto apoiorenner;
      
}
inicio:
if (apoira.apoios == 1)
{
      Console.ResetColor();
continua();

} else if (apoira.apoios == 2)
{
  Console.ResetColor();
     continua1();

} else if (apoira.apoios == 3)
{  Console.ResetColor();
continua2();
} else if (apoira.apoios == 4)
{  Console.ResetColor();
continua3();
} else if (apoira.apoios == 5)
{
Console.ResetColor();
continua4();
} else if (apoira.apoios == 6)
{

Console.ResetColor();
continua5();
}
else if (apoira.apoios == 7)
{

Console.ResetColor();
continua6();
}
{
goto inicio;
}
}
string[] dialogos = {
    "...",
    "Diante do golpe final, você ouve passos ferozes vindo em sua direção, um grande choque e, em seguida, presenceia o Baratão deslocado de sua presença. Embora sua visão esteja turva, assim como sua capacidade de discernir a realidade, pode-se ver uma figura marrom e esguia, o qual foi o responsável pela sua sobrevivência, enfrentando o seu oponente.",
            "...Você conhece este corpo. Esta estrututura e... estas antenas. Você o viu antes... Você lutou com ele antes.",
            "É o Baratus Pirokudos...!",
            "Você então passa contemplar a luta entre eles. Patas, bateres de asas e grunhidos indescritíveis podem ser concebidos.  Um verdadeiro contraste entre fraqueza e força. Porém, não há nada o que você possa fazer.",
            "Muito embora Pirokudo seja mais alto e o Baratão esteja ferido, é evidente que esta causa esteja perdida. Baratão possui muito mais habilidades e condicionamento físico que o seu salvador...",
            "Diante do fato de que o fim da luta e, adiante, da sua vida, esteja próximo, você cria esforços para levantar.",
            "Agora a batalha não é contra baratas, gnomos ou seres humanos. É contra você.",
            "Você.",
             "Você tenta levantar. Mesmo fraco, você exerce a força de leões para sobressair à batalha.",
            "Entretanto, a força da gravidade foi mais forte e o fez cair.",
              "Seu amigo não está mais no pódio da vitória e está, aos poucos, perdendo a batalha.",
             "...",
             "......",
             "''.....Eu... eu não consigo! Eu sou um merda! Minha vida estaria melhor se eu não nascesse! Nada disso teria acontecido!! Não importa o quanto eu tentasse, NÃO MUDOU PORRA NENHUMA!!!''",
             "Você começa a chorar. Para você, agora a esperança é uma tolisse, e a inexistência parece soar como uma doce voz a lhe chamar no fim de tudo. Talvez o Baratão não estivesse tão louco assim...",
             "...",
             ".....",
             "........",
           
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
     }
    
         apoira.apoios = 1;
         apoiorenner();

         void continua()
         {


string[] dialogos0 = {
    "''...''",
    "''Como... Quem é?!''",
            "''Não pode ser...''",
            "''....''",
          
           
           
        };

     foreach (var dialog in dialogos0)
     {
         Console.WriteLine(dialog);
        Console.ReadKey();
     }

apoira.apoios = 2;
apoiorenner();
         }

         void continua1()
         {
            
string[] dialogos1 = {
    "...",
    "''Quem é você?!... SAIA DA MINHA CABEÇA!''",
            "''É VOCÊ O 'CRIADOR'??''",
            "....",
            ".......",
            "''Eu não sou nada... não tenho nada... eu... eu...''",
           
           
        };

     foreach (var dialogoss in dialogos1)
     {
   
         Console.WriteLine(dialogoss);
        Console.ReadKey();
     }
           apoira.apoios = 3;
            apoiorenner();
         }

         void continua2()
         {
            
string[] dialogos2 = {
    "...",
    "''Por que? Por que disto tudo?''",
            "''Eu não sou nada...''",
            "''Eu não tenho nada...''",
            "''Sou um fodido.''",
            "''Não sou nada...''",
           
           
        };

     foreach (var dialogosss in dialogos2)
     {   Console.WriteLine(dialogosss);
        Console.ReadKey();
     }
     apoira.apoios = 4;
     apoiorenner();
         }

           void continua3()
           {
            string[] dialogos1 = {
    "...",
    "......",
    ".......",
    "''E-eu consigo?...''",
           
           
           
        };

     foreach (var dialogoss in dialogos1)
     {

         Console.WriteLine(dialogoss);
        Console.ReadKey();
     }
     apoira.apoios = 5;
     apoiorenner();
           }

 void continua4()
           {
          Console.WriteLine("''Eu consigo...''");
          Console.ReadKey();
     apoira.apoios = 6;
     apoiorenner();
           }

           
 void continua5()
           {
          Console.WriteLine("''Eu consigo!''");
          Console.ReadKey();
     apoira.apoios = 7;
     apoiorenner();
           }


           
 void continua6()
           {
          Console.WriteLine("''EU CONSIGO!!''");
          Console.ReadKey();
    Console.BackgroundColor = ConsoleColor.Red;
     Console.WriteLine("VOCÊ É FODA, CAUÃN RENNER!");
     Console.ResetColor();
     Console.ReadKey();
     finall();
           }

           void finall()
           {
      
string[] dialogogos = {
    "Parece que alguma coisa o contatou. Uma figura além deste reino, além deste mundo. Seria esse ser o Criador, dando forças a você?",
            "Indepentemente, isso lhe reacendeu a chama que jazia apagada dentro de você. Com isso, mesmo ferido, suas forças reapareceram e compactuaram para a sua vitória contra a gravidade.",
            "Ao se levantar, você vê o Pirokudos ferido.",
            "Baratão o ataca. O ataque foi tão grande que emitiu um grande estrondo que abalou a estrutura do ambiente, decretando de vez o fim de Pirokudos.",
            "''NÃO!''",
            "''NÃO!!!''\n–Você disse.",
            "Ira, ira, ira! Tanta ira!!!",
            "Em decorrência de sua ira, uma áurea se reveste ao seu redor, e, diante das suas mãos, uma força começa a se manifestar.",
            "Por alguma razão, suas mãos tornaram-se punhos de ferro, e isso te deixou forte e o fez recuperar todas as energia que um dia dissiparam.",
            "Mas seu foco agora não é admirar o novo poder desbloqueado... ",
            "Sem pensar duas vezes, você parte para cima do Baratão, e com apenas um soco consegue causar sérios danos ao inimigo.'",
             "''COMO?''\n –Ele pergunta, surpreso.",
            "Embora Baratão tentasse revidar, suas habilidades atingiram o ponto máximo, e agora você sente facilidade em desviá-lo.",
             "Você ataca o Baratão na ferida, e ele cede à dor, caindo no chão. ",
             "...",
             "Você acha curioso como, de um passo para o outro, as coisas mudaram tanto de posição. Parece que o jogo virou mesmo.",
             "Em sua mente, não existe mais nada além de raiva, ira e busca pelo que você, naquele momento, interpreta como 'justiça'.",
             "Você o finaliza ali mesmo.",
             "Socos e punhaladas.",
             "Socos e punhaladas...",
             "Socos e punhaladas......",
             "Socos e punhaladas........",
             "Socos e punhaladas...........",
             "...",
             "Agora não existe mais 'Baratão', apenas uma poça de sangue e estruturas orgânicas que um dia compuseram um ser vivo.",
            ".....", 
            ".......",
            "Sua raiva passa, e agora você não enxerga mais ira e raiva em suas mãos, mas sim culpa e arrependimento.",
            "''Oh meu Deus, o que eu fiz?''",
            "''...Eu sou um monstro! UM MONSTRO!''",
            "''Eu sou um monstro... um monstro... um monstro... uma aberração sanguinária!''",
            ".....",
            "''Garoto!''–Disse uma voz abafada.",
            "Não pode ser...",
            "Pelo visto, Pirokudos ainda se encontra vivo, mas extremamente debilitado.",
               "Você chega perto dele e observa que aquele é, infelizmente, o fim de Pirokudos, e que agora não há mais nada o que possa ser feito senão acompanhá-lo em seu último momento de vida.",
                       "''Eu... COF COF- Ouvi histórias quando eu era uma pequena ninfa... Elas diziam  que, um dia, um grande homem com punhos de ferro surgiria e enfrentaria uma grande barata que anseia pelo fim da existência. Durante anos, me questionei o que tudo isso poderia significar... Mas não entendia nada COF COF.''",
                        "Porém agora, Renner, eu entendo tudo. O nome do Grande Home?",
                        "TINY. Tiny era o seu nome.",
                         "...",
                          "...Você é o Tiny, Renner! E o Baratão era a má barata...",
                           "COF COF",
                            "''Eu ainda não creio que participei disto tudo. Uma lenda se tornou verdade e eu participei dela, quem diria... COF COF''",
                             "''Mas, este é o meu fim. Viva por mim, TINY... Adeus-''",
                              "Diante de tais palavras, Cauãn Renner, que agora descobriu ser o Tiny, se derraba em lágrimas após o falecimento de Pirokudos.",
                               "Desse dia em diante, Cauãn Renner mudou. Não é mais aquele garoto isolado como uma xícara de café esquecida no canto de uma mesa. Ele está mais forte, sábio e, principalmente, determinado.",
                                "Com o surgimento de seu novo poder, Cauãn Renner percebeu que o seu dever agora é proteger os cidadãos. Com isso, Cauãn Renner, vulgo Tiny, tornou-se o novo herói da vizinhança.",
                             "''...Eu sou aquele que vai viajar.''",
                                "''Farei a justiça e a verdade cúmplices de minha jornada. Anseio compreender este mundo que vos criou, seus mistérios e curiosidades, ao passo que faço bem a quem estiver aquém!''",
                                  "''Meu nome é Cauãn Renner, o Tiny, e eu não vou parar!''",

                            
           
        };

     foreach (var dialogogo in dialogogos)
     {
         Console.Clear();
         Console.WriteLine(dialogogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
         Console.ReadKey();
       
     }
     escolhas();
           }

void escolhas()
{
 
escolhas:
Console.Clear();
   Console.WriteLine("Você zerou o final feliz da história, parabéns! Gostaria de jogar o outro final?");
Console.Write("Escolha [s/n]: ");
char escolha = char.Parse(Console.ReadLine());
if(escolha == 's' || escolha == 'S')
{
Console.Clear();

Program.Main(null);
} else if (escolha == 'n' || escolha == 'N')
{
Console.Clear();
Console.WriteLine("Obrigado por jogar!");
} else {

Console.Clear();
goto escolhas;
}
}
}


public void PirokudosMorto()
{

string[] dialogos = {
    "Diante de você, Baratão introduzi a pata bem fundo em seu corpo.",
    "Dor.",
    "Dor.",
    "Dor...",
    "Dor... Mas nem tanta.",
    "Vigor?...",
    "....",
    "Por alguma razão estapafúrdia, você consegue desvencilhar, com certa facilidade o Baratão de você, muito embora gravemente ferido.",
    "...Parece que, de alguma forma, você ganhou forças enquanto era empalado. ",
    "Ao olhar suas mões, percebe que elas estão metálicas. O que seria isso? Um poder oculto manifestado em última instância?",

    "Como a fúria de quem se recusa a perder, Baratão vem com tudo para cima de você",
    "A porradaria se inicia, e você não parece tão atrás quanto antes.",
    "Uma luta sangrenta, de igual para igual, é viabilizada. De um lado, há farpas, fios e patas ferozes, direcionadas contra o oponente. Por outro lado, existe um jovem com forças desconhecidas lutando pela sua sobrevivência, ao passo que tenta fazer justiça com suas próprias mões.",
           "Você acerta o Baratão na ferida que uma vez acertara, fazendo-o ceder à dor e, em seguida, bravando com fúria colossau em sua presença. Infelizmente, você não conseguiu desviar do golpe desta vez e declivou ao chão.",
           "''HAHAHAHA! Sabe o que nos separa, Cauãn Renner? Não são as asas, não são as patas ou carapaças. É a inteligência!''\n–Disse, enquanto o bombardeava de socos",
           "socos.",
           "socos....",
           "socos.....",
           "''VOCÊ''",
            "''SEMPRE''",
             "''FOI''",
             "''UM''",
              "''BOSTA!''",
              "Você, embora ferido, observa que o baygon que trouxe estava ao seu lado. Esta pode ser a sua última chance de sobrevivência.",
              "''Eu posso ser um bosta sim...\n– você conseguiu exprimir, levantando a curiosidade do inimigo de como você ainda permanece acordado.''",
              "''Mas, EU NÃO SOU MAIS O *SEU* BOSTA!!!''",
           
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
       Console.ReadKey();
     }
Console.Clear();
    Console.BackgroundColor = ConsoleColor.Red;
     Console.WriteLine("Aperte qualquer botão para ATACAR.");
     Console.ResetColor();
     Console.ReadKey();


     
string[] dialogoss = {
    "Você, subitamente, pega o Baygon e o desfere na ferida de Baratão e, posteriormente, em seu rosto, bloqueando sua traqueia.",
    "Baratão se debate ao redor, e, violentamente, busca acertá-lo a todo custo, mesmo cego temporariamente.",
    "''Onde está você! Seu MERDA!''",
    "Você, claro, se desloca para um canto estratégico, buscando encontrar o momento ideal de finalizá-lo.",
    "Em cima de uma grande rocha, você pula e direciona o seu punho na face do animal.",
    "O golpe foi fatal.",
    "....",
    ".......",
    "...........",
    "...",
    "''...Este é o fim.''",
    "''O fim de tudo.''",
    "''Espero que tenha feito a escolha certa, Cauãn Renner.''\n–Dizia, sob gorgolejos.",
           "Um grande estrondo surge que compreende todo o reino. Pessoas gritam, e um aparente caos começa a reinar.",
           "''Ouve isto? É a MORTE.''",
           "''O fim do programa.''",
            "''No fim das contas, você cumpriu bem o seu papel, assim como eu cumpri o meu. Agora logo estaremos dispersos no mar da inexistência, permeando uma realidade que não existe, sob um passado anômalo e irreal.''",
             "''COF COF...Obrigado, Cauãn Renner. Obrigado por tudo.''",
              "....",
              "incrédulo com o que acabou de conceber, você corre para fora da caverna à procura de saber o que está acontecendo.",
              "Ao sair da formação rochosa, encara a pura realidade diante dos seus olhos: formas abstratas, como ondas elétricas, haviam cercado o reino como uma cúpula, que agora está se fechando, destruindo tudo em seu caminho.",
              "''OH MEU DEUS, ELE ESTAVA CERTO! TUDO É UMA ILUSÃO!''",
              "NÃO!",
              "''NÃO, NÃO, NÃO, NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO,NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO, NÃO!!!!!''",
              "''ISTO NÃO PODE ESTÁ ACONTECENDO!!!''",
              "''Não pode... não....''",
              "''Não......''",
              "Você corre para a sua casa. Já que não há nada o que fazer, você decide passar os últimos minutos ao lado de sua mãe e seus irmãos.",
              "Ao chegar em casa, vê que sua família está amedrontada e incerta acerca da origem do estranho fenômeno. O medo estampado em suas faces, assim como o discernimento do que se está vindo, fez você sentir um aperto no peito.",
              "''É tudo minha culpa, mãe! É tudo a minha culpa! Me desculpem! Me desculpem! Me desculpem!''",
              "Você os abraça, e, embora eles não o entenda, estão aptos a perdoá-lo de tudo. Porque eles te amam.",
              "E assim, mediante ao fim do mundo, Cauãn Renner passa os seus últimos momentos ao lado daqueles que ama.",
              "No entanto, mesmo no fim, ele se questiona se existiu algo que ele poderia ter feito para evitar isto tudo. De repente ter tomado alguma escolha diferente? Ele não sabe.",
              "E assim, a cúpula de zeros e uns se fechou, reduzindo toda aquela realidade à 'inexistência'.",
              "Agora não existe mais nada senão o próprio reinado do caos, a máxima dispersão da entropia e a ausência de tudo.",
              "Vazio.",
              "Vazio...",
               "Vazio.....",
                "Vazio.....",
                 "....",
                  "Vazio.",
                  "",
              "RIP Cauãn Renner.\n 11/09/2001 - 29/01/2025.",
           
        };

     foreach (var dialog in dialogoss)
     {
         Console.Clear();
         Console.WriteLine(dialog);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
       Console.ReadKey();
     }

     
Console.Clear();
    Console.WriteLine("Você zerou o final triste da história, parabéns! Gostaria de jogar o outro final? Se for jogar, faça as escolhas certas dessa vez!");
escolhas:
Console.Write("Escolha [s/n]: ");
char escolha = char.Parse(Console.ReadLine());
if(escolha == 's' || escolha == 'S')
{
Console.Clear();

Program.Main(null);
} else if (escolha == 'n' || escolha == 'N')
{
Console.Clear();
Console.WriteLine("Obrigado por jogar!");
} else {

Console.Clear();
goto escolhas;
}
}


}
class Caminho : Quarto
{

    public void Cima()
    {

        
        
string[] dialogos = {
    "Após o desvio, você deu mais uma canetada no Baratão, acertando, pelo visto, um ponto fatal.",
            "Baratão caiu no chão. Parece abatido. Ele olha para a ferida e percebe estar mais próximo da morte.",
            "Ele passa a sangrar, e de sua boca sai um líquido branco com textura de gel. Parecia um sorriso doentio perante o último suspiro de vida.",
            "Baratão deita ao chão e parece desfalecer-se.",
            "Você se aproxima do corpo.",
            "...",
            "''Como você é tolo!''\n–surpreendeu o Baratão, ainda vivo, enquanto começa a investir contra você, mesmo, evidentemente, ferido.",
            "Você apenas sente os socos sendo disparados contra você como um alvejamento de facção no RJ. Estrelas e tonturas lhe veêm enquanto apanha, mas, infelizmente, você já perdeu muitas forças.",
            "Você agora se encontra no chão, imóvel; acabado. Se ele quisesse, poderia destruí-lo agora mesmo. Entretanto, ele cessa a investida.",
            "E, ao vê-lo caído no chão, como uma simples flor frágil brochada, Baratão olha as patas, observa o que fez e, em decorrência de um arrependimento seguido de fúria, começa a indagá-lo.",
            "''POR QUE VOCÊ ME FEZ FAZER ISSO?!''",
            "....",
            "''SE VOCÊ NÃO EXISTISSE, TALVEZ NADA DISSO TIVESSE ACONTECIDO, POIS O 'CRIADOR' CRIOU ESTE MUNDO CIBERNÉTICO BASEADO EM UM OUTRO CAUÃN RENNER! PENSA RENNER, PENSA!!!''",
            "....",
            "''...Mas agora não há mais nada que possa ser feito; o que existe, já aconteceu, e o que acontecerá, é inevitável... Apenas ratos em direção à ratoeira, haha...''",
             "''...Você faz parte de uma coisa que nem consegue compreender. Uma coisa maior que eu, que você e tudo o que assume como 'realidade'. E mesmo assim se recusa a compreender o que está diante dos seus olhos... No fim das contas, talvez a irracionalidade realmente seja uma benção.''",
             "...",
            "''Não me julgue mal, Cauãn Renner; também sou uma marionete aqui. A diferença é que consigo ver as cordas que nos manipula.''", 
            "...",
            "''eu... só quero terminar isso logo...''",
            "...",
            ".....",
            ".......",
            "''...Adeus, Cauãn Renner.''",
            "Baratão se prepara para finalizá-lo.",
           
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
     }
  
     Final vivomorto = new Final();


if (vivo == true)
{
    vivomorto.PirokudosVivo();
}
else 
{
    vivomorto.PirokudosMorto();
}

    
    }
    
public void esquerda()
{
string[] dialogos = {
    "Você consegue se desviar do Baratão e também consegue acertar um golpe em suas asas com a caneta que trouxe, fazendo-o ranger de dor e, logo em seguida, revidar o ataque.",
            "Dessa vez ele saca suas garras ferozes de Barata de Chernobyl e investe um ataque na horizontal",
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
      Console.ReadKey();
     }

     
    
Console.WriteLine("Para que lado você pretende se desviar do ataque?");

Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Para que lado você pretende se desviar do ataque?\n1. Baixo.\n2. Cima.");
        
        Console.ForegroundColor = ConsoleColor.White;
        rescolher:
        Console.Write("Escolha uma opção: ");
        int escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1)
        {
              Console.WriteLine("Você se abaixou mas o ataque acabou decapitando a sua cabeça.");
          Console.ReadKey();
            Console.WriteLine("''Se você, assim como eu, fosse uma barata, até poderíamos continuar lutando mesmo você sem cabeça. Mas pena que não é, hahahaha!''");
          Console.ReadKey();
GameOver gameover = new GameOver();
gameover.Gameover(gameover.escolha);
            
            

        } else if (escolha == 2)
        {
            Console.WriteLine("Você pulou e conseguiu, por pouco, desviar do ataque maquiavélico do Baratão.");
           Console.ReadKey();
            Caminho caminho = new Caminho();
            caminho.Cima();
        } else 
        {
             Console.WriteLine("Escolha uma das duas opções. Seu Tiny!");
            goto rescolher;
        }
        

}

public void Passou()
{

 string[] dialogos = {
    "Acertaste a charada, nobre guerreiro. Agora podes passar, e tornar-se o herdeiro!",
            "Você entrou na caverna do Baratão. O silêncio angustiante e a infraestrutura lhe dava devaneios. Cada passo que você dá soa como uma presa indo em direção à armadilha",
            "Mas você é Cauãn Renner, e já passou por coisas piores. Até fez a proeza de tirar 520 na redação. E embora fúnebre, o ambiente agora lhe enche de Determinação!",
            "...",
            "...",
             $"''Ora, ora, se não é Cauãn renner.''\n – Disse uma voz",
             "Você se vira e percebe ser quem esperava.",
             "Aquele definitivamente não parecia mais o Baratão que um dia conheceu. Estava acabado e desnutrido. Mas, o seu olhar de psicopata continuara o mesmo.",
             "Ele não parecia a mesma pessoa. Algo de muito errado aconteceu com ele, e defintivamente não foi algo normal.",
             "Obstinado, você encara o rosto da criatua e fala que ele tirou tudo de você: sua dignidade, alimento, felicidade e, agora, a única coisa que lhe restara.",
             "Você diz que cansou de tudo isso e que ele passou dos limites.",
             "''HA HA HA HA HA HA''",
             "''HA HA HA HA HA HA HA HA!''",
             "''HA HA HA HA HA HA HA HA HA HA!''",
             "''Como pode ser tão cego, Cauãn Renner?!''",
             "''Do que diabos você está falando, porra?!''\n – você retruca.",
             "Ele, pacientemente, conta a razão de sua risada, e a razão pela qual fez tudo perder o sentido. ",
             "enquanto falava, ele não parecia louco. Pelo contrário: Parecia mais são do que nunca. Suas falas e pensamentos lógicos iam em contraste com o estado atual da pobre criatura. O que aconteceu com ele?",
             "À media em que ele exprime, suas falas ressoam como um chicote açoitando o seu coração de negro. Isso não pode ser verdade...",
               "Ele conta que nada disso é real. Que vivemos em uma simulação, um projeto caseiro estruturado por um ser de uma dimensão adjacente à nossa.",
                 "Que no lado de lá tudo é constituído por cordas e átomos, enquanto aqui zeros e uns.",
                 "Conta que este mundo é projetado por linhas de comandos lógicos, estruturados de tal modo a predestinar nossas ações, pensamentos e vivências. E que, portanto, nada disso fazia mais sentido.",
                 "Nossas dores, virtudes, felicidades e tristezas...",
                 "Tudo falso.",
                   "Ele disse que não sabia totalmente a razão disso tudo, mas, suspeita que tudo fora estruturado com o objetivo de recreação.",
                   " Disse que ao furtar a sua lista, milhões de informações vieram-lhe à mente, como vozes intrinsecamente tangenciais compartilhando a verdade metafísica.",
                     "Cada fala da criatura ressoava como uma facada em seu peito. Embora absurdo, por alguma razão isso não pareceu tão louco quanto deveria..",
                       "Por fim, ele disse que não sabia como, mas que estamos destinados a lutar até a morte e que, enfim, tudo voltará à 'inexistencia.'",
                        "...Mas você não conforma com as informações, e diz que ele deixou o poder subir à cabeça e que isso o fez enlouquecer.",
                        "Baratão expressa indiferença. E isso faz você refletir.",
                        "...",
                        "''VOCÊ NÃO ENXERGA?!!! OLHE AO SEU REDOR, 'CAUÃN RENNER'! NÃO PERCEBE COMO NADA DISTO FAZ SENTIDO?!!!''",
                        "''....''",
                        "''NUNCA ESTRANHOU COMO TUDO PARECE INDIFERENTE, IRRISÓRIO E ESDRÚXULO?!''",
                        "...",
                        ".....",
                        "...",
                        "''...VOCÊ AO MENOS SABE O SEU NOME COMPLETO?''",
                        "''É claro que eu sei!!! Meu nome completo é Cauãn Renner...''\n– você tenta retrucar.",
                        "''Cauãn Renner...''",
                        "''....''",
                        "''VIU?! Abra os olhos, moleque!''",
                        "De repente, tudo fica mais preto e branco. O colorido assume tons de cinza e o céu não parece mais azul. Sua realidade desaba. ",
                        "Mas, nada disso pode ser verdade! Você acredita que grandes afirmações exigem grandes provas. Fora que...",
                        "''....Se tudo isso for verdade... então... é-é só não lutarmos! Deste modo, a inexistencia não será um evento canônico!''\n –diz você",
                        "Uésilei Baratão rebate e diz que você é um homem de pensamento fraco, e que, não importa o que façamos, tudo estará destinado ao fim. Disse que, à medida em que falamos, tudo se converge cada vez mais para o fim do prompt. E, contudo, que precisamos lutar para adiantar o que já é inevitável de acontecer.",
                        "Você renega isso, e fala que deve existir um jeito de quebrar o inquebrável.",
                        ".....",
                        "''Se você quer sofrer e lutar contra forças que não consegue vencer, problema seu. Eu quero voltar à inexistência. Você é apenas um objeto, e eu o usarei para o meu fim, não importa se queira ou não!''",
                        "Baratão perde a paciência e parte para cima de você.",
                        "Com um semblante de rancor, fúria e, ao mesmo tempo, piedade, Baratão lhe ataca. Mas você tem tempo de se desviar!",
                       
             
             
            
                             
          
           
           
            
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
         Console.ReadKey();
     }

    
Console.WriteLine("Para que lado você pretende se desviar do ataque?");

Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Para que lado você pretende se desviar do ataque?\n1. Esquerda.\n2. Direita.");
        
        Console.ForegroundColor = ConsoleColor.White;
        rescolher:
        Console.Write("Escolha uma opção: ");
        int escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1)
        {
            Caminho caminho = new Caminho();
            caminho.esquerda();
            

        } else if (escolha == 2)
        {
            Console.WriteLine("Você foi para a direita mas não conseguiu desviar do golpe do Baratão. Você se feriu e ficou atordoado, mas antes do golpe final, o seu oponente olha para você");
            Console.ReadKey();
            Console.WriteLine("''Não me julgue mal, Cauãn Renner. Nada mais sou que linhas de comandos dentro de um computador. Adeus, Cauãn Renner. E até à inexistência.''");
           Console.ReadKey();
            Console.WriteLine("Baratão come o seu cu.");
           Console.ReadKey();
GameOver gameover = new GameOver();
gameover.Gameover(gameover.escolha);
        } else 
        {
             Console.WriteLine("Escolha uma das duas opções. Seu Tiny!");
            goto rescolher;
        }
        
   
     

}
public void gnomos()
{
    if (escolha == 1)
    {
vivo = false;
    } else if (escolha == 2)
    {
        vivo = true;
    }



 string[] dialogos = {
    "Em seguida, você pôde ver, ao longe, a caverna do Baratão.",
            "entre você e a caverna do Baratão existe uma ponte inoperada.",
            "entretanto, ao chegar perto, você viu a presença de um gnomo baixinho e bombado, que se apresentou como John Gaybriel.",
            "ele prõe permitir sua passagem caso você consiga solucionar a charada que ele pretende lançar.",
             "''jovem humano, caso queira do outro lado chegar, terá que minha charada desvendar''",
             "''Preste bastante atenção no que estou prester a dizer. Caso contrario, receio que possas morrer.''\n – Dizia o Gaybriel",
             "''Já vali, mas hoje não possuo valor. De minha fama, só existe o fedor, e no Rei Leão, eu já fui um ator.''",
             
            
                             
          
           
           
            
        };

     foreach (var dialogo in dialogos)
     {
         Console.Clear();
         Console.WriteLine(dialogo);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write( "\n Clique qualquer seta para continuar.");
         Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
     }
     
Console.Clear();
Console.WriteLine("Digite apenas com letras minúsculas. Fiquei com preguiça de usar ToLower ou ToUpper.");
       Console.ReadKey();
  
     Console.WriteLine("Quem sou eu?");
     recomeço: 
     int j = 0;
     while (j < 4)
     {
j++;


      Caminho passou = new Caminho();


  Console.ForegroundColor = ConsoleColor.Yellow;
       Console.Write("Resposta: ");
        Console.ForegroundColor = ConsoleColor.White;
  string resposta = Console.ReadLine();
    
   
     if (resposta == "javali" || resposta == "Javali")
     {
passou.Passou();
break;
     } else if (resposta != "Javali" && resposta != "javali" && j < 4)
     {
     
      Console.WriteLine($"esta foi a {j} tentativa de 3. Tente mais uma vez!"); 
      
     }
 if (j == 4)
 {
Console.WriteLine("O gnomo lançou uma mandinga sobre você, fazendo os seus olhos saltarem das órbitas. Intankável, não tem como."); 
Console.ReadKey();
GameOver gameOver = new GameOver();
gameOver.Gameover(gameOver.escolha);
 }
       

   
     }

}
      
}

    public class Quarto
    { 
        
  public static bool vivo;
public int escolha;
        public void quarto()
        {
         Caminho gnomo = new Caminho();
            Quarto quarto = new Quarto();

 string[] dialogos = {
            $"Uma vez no quarto, você se senta para ter uma aula particular de matemática sobre multiplicação, com o seu professor chamado Hector Bananão",
            "No entanto, ao procurar o caderno, você sente falta da sua tão importante Lista",
            "Você procurou no quarto...",
             "Na sala...",
              "No banheiro...",
               "Quintal...",
                "...Tudo.",
                 "Porém nada.",
                  "resignado no quarto, você passa a perder as esperanças.",
                   "Mas, ao olhar à janela, viu uma pata de barata",
                    "Apesar da residência sofrer um enxame de baratas, aquela era diferente: Era ENORME.",
                     "Com isso, você chega a conclusão de que o seu caderno foi furtado, e o ladrão só pode ter sido o UÉSILEI BARATÃO!",
                      "O Baratão é o seu pior inimigo. Ele já lhe humilhou inúmeras vezes na frente dos seus colegas.",
                       "Já lhe chamou de 'Punhetinha', só pelo simples fato do gesto que você faz ao escrever em sua lista ser um pouco sujestivo. ",
                        "E você aguentou toda essa humilhação calado. Em sua cabeça, os calados sempre vencem...",
                         "No entanto, dessa vez ele passou dos limites! Isso não pode continuar assim!",
                          "Embora relutante à princípio, você cria coragem para enfrentá-lo. Prontamente, você se retira da residência, assumindo uma causa incerta. Uma caneta, um Baygon e o espírito de justiça o conduz para fora de casa.",
                           "Na rua, você fita um dos capangas do Baratão, uma das baratas mais esguias existentes: O Baratus Pirokudos.",
                            "Você parte para cima dele, como a fúria de mil gnomos voltados à um gigante.",
                             "Mas, estranhamente, ele não reage da maneira esperada.",
                               "''calma brasilero, calma brasileiro!'', dizia ele enquanto você o descia na porrada.",
                                 "Após alguns minutos de porradaria, você enfim cessa a briga, uma vez que a criatura apenas se defendera, e em nenhum momento o atacou, efetivamente.",
                                   "EU NÃO SOU MAIS UM CAPANGA DO BARATÃO, RENNER! NÃO MAIS! AGORA PARE DE ME BATER E ME OUÇA PELO AMOR DE DEUS!\n – dizia.",
                                     "Obstinado, você decide ouví-lo. Ele conta que o Baratão perdeu o controle, e deturpou sua personalidade ao ponto de enlouquecer. Disse que, desde sua loucura, tornou-se obssessivo pelo poder, pelo dinheiro e pelos pertcences dos outros ",
                                       "Em lágrimas, ele expressa não reconhecer mais o seu amigo, e que agora não sabe mais o que fazer.",
                                         "Disse que estava passando por um momento difícil em sua vida, e que não está feliz com vida. Disse que, considerando tudo o que ele fez a você, não lhe julgaria caso você decidisse prestar vingança.",
                                           "Você passa a lembrar de todas as vezes em que o Baratus lhe humilhou; tanto quanto o próprio Baratão.", 
                                             "Você direciona o Inseticida Baygon que estava em suas mãos e, relutante, pensa em vingar-se dele.",
                             
          
           
            
        };









        foreach (var dialogo in dialogos)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( $"\n Clique qualquer seta para continuar");

Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();

        }
       
Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("se vingar do Baratus Pirokudos?\n1. Matar.\n2. Poupar.");
        
        Console.ForegroundColor = ConsoleColor.White;
        rescolher:
        int escolha = int.Parse(Console.ReadLine());
      
        if (escolha == 1)
        {  
   

vivo = false;
         string[] dialogos2 = {
            "Você usou o spray que possuía em Baratus Pirokudos, atordoando-o e fazendo-o sofrer antes de, enfim, desfalecer-se.",
            "Após tamanho ato, você se retira do ambiente, indo em direção à caverna do Baratão, que, agora, pode ser vista ao longe.",
            
        };

        foreach (var dialogo in dialogos2)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( $"\n Clique qualquer seta para continuar.");

Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }
Console.Clear();


gnomo.gnomos();
return;
        } else if (escolha == 2)
        {  
              quarto.escolha = 2;

vivo = true;
        string[] dialogos1 = {
            "''Eu posso ser pobre, mas não sou assassino.''",
            "''vai-te, pobre barata. Vai e abstenha-se dos teus problemas. Sejais a Super-Barata!''",
             "assim falou Cauãn Renner.",
              
        };

        foreach (var dialogo in dialogos1)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( $"\n Clique qualquer seta para continuar.");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }
       
        
Console.Clear();


gnomo.gnomos();
return;
        } else 
        {
             Console.Write("Escolha inválida. Escolha novamente: ");
goto rescolher;

        }


        }
    }
 public class GameOver
{
    public char escolha;
    public void Gameover(char escolha)
    {
        this.escolha = escolha;
    
Console.BackgroundColor = ConsoleColor.Red;
           Console.WriteLine($"\n FIM DE JOGO \n");
           Console.ResetColor();
           Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n Jogar novamente [s/n]?\n");
           Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"\n Resposta: ");
        escolha = char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha == 'S')
        {
            Program.Main(null);
        } else
        {
              Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine($"\n Bye!\n");
             Console.ForegroundColor = ConsoleColor.White;
        }

    }

}
   sealed public class Comida{
protected string comida;
        public void Tomate (string comida)
        {
this.comida = comida;
 string[] dialogos = {
            $"Você comeu alguns {comida}s e ficou satisfeito.",
            "Você, então, decide ir jogar Free Fire mas a sua mãe lhe impede, afirmando que você deve estudar",
               "Suas notas não eram as melhores, então estudar em casa poderia ser uma solução para essa sua aversão à escola.",
                 "Mas, você lembra que queria muito subir para mestre no FF, então fica relutante em obedecer a mãe.",
          
           
           
            
        };

        foreach (var dialogo in dialogos)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( "\n Clique qualquer seta para continuar.");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nO que você vai fazer? \n1. Obedecer a mãe.\n2. Desobedecer e ir jogar FF.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Escolha uma opção: ");
rescolher:
        int escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
          case 1: escolha = 1;
          Console.WriteLine("Você obdeceu a sua mãe e foi estudar.");
          Quarto Quarto = new Quarto();
          Console.ReadKey();
         Quarto.quarto();
          break;

          case 2: escolha = 2;
          
        string[] dialogos1 = {
            "Você desobedeceu a sua mãe. Que coisa feia!",
            "Durante a partida do Free Fire, você foi tão bem, tão bem na partida, que isso mexeu com o temperamento de um hacker psicopata do jogo.",
            "Com isso, ele conseguiu hackear a sua localização e, por ser Russo, emitiu uma bomba à sua residência.",
            "E você morreu.",
            "Moral da história: Obedeça a sua mãe...",
             "Renner!",
           
            
        };

        foreach (var dialogo in dialogos1)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( "\n Clique qualquer seta para continuar.");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }

Console.Clear();
GameOver gameOver = new GameOver();
gameOver.Gameover(gameOver.escolha);
          break;

          default:
          Console.Write("Escolha inválida. Escolha novamente: ");
goto rescolher;
        
        }

        }

         public void Alho (string comida)
        {
this.comida = comida;

   string[] dialogos1 = {
            "Você comeu um Alho.",
            "No entanto, o alho estava podre e acabou desenvolvendo um fungo mortal ao maior estilo The last of us e você acabou virando um Infectado.\n",
           
           
            
        };

        foreach (var dialogo in dialogos1)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( "\n Clique qualquer seta para continuar.");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }
GameOver gameOver = new GameOver();
gameOver.Gameover(gameOver.escolha);
        }
      }

class Program{
    public static void Main (string [] args)
    {
 
        string[] dialogos1 = {
            "Imagine que você é um jovem rapaz chamado Cauãn Renner, e vive, pacificamente, em sua residência situada embaixo de uma ponte",
            "Não é o melhor lugar para se viver, você admite; mas, é aconchegante o suficiente para você chamar de 'lar'",
            "Com suas mãos morenas, um lápis e uma folha de papel, a sua maior diversão é fazer lista de coisas que gostaria de fazer em seu cotidiano e jogar Free Fire.",
            "Você ficou com fome e se dirige à geladeira.",
           
           
            
        };

        foreach (var dialogo in dialogos1)
        {
Console.Clear();
Console.WriteLine(dialogo);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write( "\n Clique qualquer seta para continuar.");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
        }

Console.Clear();
        

        //condições:
                Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine( "Lá você percebe que só tem tomate e alho. As baratas comeram todos os outros alimento e deixaram apenas esses. O que vai escolher comer?\n1. Tomate.\n2. Alho.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write( "Resposta: ");
       int comidas = int.Parse(Console.ReadLine());
       if (comidas == 2)
       {
        Comida comida = new Comida();
        comida.Alho("alho");
    } else if (comidas == 1)
    {
         Comida comida = new Comida();
        comida.Tomate("tomate");
    } else
    {
        Console.WriteLine("Digite uma opção válida! renner.");
    }
    }
}
}



/*
    
public interface Idesconto
{
    public void CalcularDesconto(double precoBase);
}

abstract class Produto{
    public string nome {get; set;}
    public double PrecoBase {get; set; }

    abstract public void ExibirDetalhes();
}

class ProdutoFisico : Produto{


        public override void ExibirDetalhes(){

            Console.WriteLine($"Nome: {nome}\n Preço Base: {PrecoBase}\n Tipo: Produto físico");
        }

    }


class ProdutoDigital : Produto{

      public override void ExibirDetalhes()
        {
           
            Console.WriteLine($"Nome: {nome}\n Preço Base: {PrecoBase}\n Tipo: Produto digital");
        }
}

public class DescontoComposto : Idesconto{

    public double precoBase;
public int desconto;

        
    
    
    public void CalcularDescontoParams(params int[] desconto){
    int guardador;
         for(int i = 0; i < desconto.Length; i++)
{
     
 
if (desconto [0] > 10)
{
    desconto[i] = 10; 
    
Console.WriteLine($"cada desconto não pode ser maior que 10%. Desconto {i} limitado à 10%."); 
return;
} else if (desconto [i] <= 10 && desconto [i] >= 0){
 this.desconto += desconto[i];
} else {
Console.WriteLine("desconto inválido");
}
     
      
}


    }
    public void Exibirdesconto()
    {
       


Console.WriteLine($"você escolheu esse total de desconto: {desconto}%");

    } 
       public void CalcularDesconto(double precoBase){
this.precoBase = precoBase;


double resultado = precoBase - (precoBase * desconto / 100);
Console.WriteLine($"{resultado}");


       
  

// return desconto      [0] = 10;
 
       }
}

class Program 
{
    static void Main(string [] args)
    {
Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();


Console.Write("Digite o preço base do produto: ");
DescontoComposto descontoCompost = new DescontoComposto();

double PrecoBaseProduto = double.Parse(Console.ReadLine());

descontoCompost.CalcularDesconto(PrecoBaseProduto);
voltar:
Console.WriteLine("O produto é físico ou digital? [F/D]");
char FD = char.Parse(Console.ReadLine());

if(FD == 'F' || FD == 'f')
{
ProdutoFisico produtoFisico = new ProdutoFisico();
produtoFisico.nome = nomeProduto;
produtoFisico.PrecoBase = PrecoBaseProduto;

} else 

{
ProdutoDigital produtoDigital = new ProdutoDigital();
produtoDigital.nome = nomeProduto;
produtoDigital.PrecoBase = PrecoBaseProduto;
} 

if (FD != 'f' && FD != 'd')
{
    Console.WriteLine("Opção inválida. Gostaria de voltar ao início? [s/n]");
    char voltar = char.Parse(Console.ReadLine());
    if(voltar == 'S' || voltar == 's')
    {
goto voltar;
    } 
    else{

        Console.Clear();
        Console.WriteLine("Bye!");
    }
}
aqui:
Console.WriteLine("Quantos descontos gostaria de aplicar? obs: 4 no máximo.");

int respostaDesconto = int.Parse(Console.ReadLine());
if(respostaDesconto > 4)
{
Console.WriteLine("Quantidade de descontos inválida. Tente novamente.");
goto aqui;

}



Console.WriteLine("Digite os descontos em porcentagem (ex: 10 para 10%).");


for (int i = 0; i < respostaDesconto; i++)
{
Console.Write($"Desconto {i+1}: ");
int descontosPorcentual = int.Parse(Console.ReadLine());

descontoCompost.CalcularDescontoParams(descontosPorcentual);

}
descontoCompost.Exibirdesconto();

Console.WriteLine("\n..... Produto Detalhado .....\n");

if(FD == 'F'|| FD == 'f')
{
ProdutoFisico produtoFisico = new ProdutoFisico();
if (nomeProduto != null)
{

produtoFisico.nome = nomeProduto;
produtoFisico.PrecoBase = PrecoBaseProduto;
produtoFisico.ExibirDetalhes();
}
} if (FD == 'D'|| FD == 'd')
       {ProdutoDigital produtoDigital = new ProdutoDigital();
           produtoDigital.nome = nomeProduto;
           produtoDigital.PrecoBase = PrecoBaseProduto;
           produtoDigital.ExibirDetalhes();
      } 
Console.WriteLine("\n--- Aplicando descontos ---\n");

Console.WriteLine($"Preço final após os descontos:");
descontoCompost.CalcularDesconto(PrecoBaseProduto);

    }   

    
}



    abstract class RelatorioBase
    {
        protected string NomeRelatorio;

        abstract public void ExibirRelatorio();

        abstract public void SetarNome(string NomeRelatorio);
    }

    class RelatorioTexto : RelatorioBase, IGeradorRelatorio
    {
        private string formato;

        public string GerarRelatorio(string formato, params object[] dados)
        {
            this.formato = formato;
            formato = "PDf";

            return string.Format(formato, dados);
        }

        override public void ExibirRelatorio()
        {
            string relatorio = GerarRelatorio(formato, "text1", "text2", "text3");
            Console.WriteLine($"Nome: {NomeRelatorio}, Formato: {formato}, dados: {relatorio}");
        }

        override public void SetarNome(string NomeRelatorio)
        {
            this.NomeRelatorio = NomeRelatorio;
        }
    }

    public interface IGeradorRelatorio
    {
        string GerarRelatorio(string formato, params object[] dados);
    }

    class RelatorioNumerico : RelatorioBase, IGeradorRelatorio
    {
        private string formato;

        public string GerarRelatorio(string formato, params object[] dados)
        {
            this.formato = formato;
            formato = "CSV";

            return string.Format(formato, dados);
        }

        override public void ExibirRelatorio()
        {
            var relatorio = GerarRelatorio(formato, "Numero1", "Numero2", "Numero3");
            Console.WriteLine($"Nome: {NomeRelatorio}, Formato: {formato}, dados: {relatorio}");
        }

        override public void SetarNome(string NomeRelatorio)
        {
            this.NomeRelatorio = NomeRelatorio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nRelatório em Texto:\n ");
            RelatorioTexto texto = new RelatorioTexto();
            texto.SetarNome("Relatorio texto");
            texto.ExibirRelatorio();

            Console.WriteLine("\nRelatório Númérico:\n ");
            RelatorioNumerico numero = new RelatorioNumerico();
            numero.SetarNome("Relatorio numerico");
            numero.ExibirRelatorio();
        }
    }



    public class Calculadora{

        public int Somar(params int [] v)
        {
            int s = 0;
            for(int i = 0; i < v.Length; i++)
            {
s+=v[i];
            }
            return s;
            
        }
    }
class Program{

static void Main(string[] args){
    Calculadora somar = new Calculadora();
    int op = int.Parse(Console.ReadLine());
char resposta = 'F';

while (op != resposta)
{
int res = somar.Somar(op);
}
 
   
    Console.WriteLine(res);
}
}


public class Veiculo {
  public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
}


public class acrescentar
{
 public int NumeroPortas {get; set;}   
 public void Exibir(int NumeroPortas)
 {
    this.NumeroPortas = NumeroPortas;
    Console.WriteLine($"Número de portas do veículo: {NumeroPortas}");
 }
}
   public class Carro : Veiculo
    {
            public void ExibirCarro(string Marca, string Modelo, int Ano)
            {
this.Marca = Marca;
this.Modelo = Modelo;
this.Ano = Ano;

Console.WriteLine($"Marca: {Marca} Modelo: {Modelo} Ano: {Ano}");
acrescentar acrescentar = new acrescentar();
acrescentar.Exibir(4);



            }
      
    }

    public class Moto : Veiculo{
           public void ExibirMoto(string Marca, string Modelo, int Ano)
            {
this.Marca = Marca;
this.Modelo = Modelo;
this.Ano = Ano;

Console.WriteLine($"Marca: {Marca} Modelo: {Modelo} Ano: {Ano}");
acrescentar acrescentar = new acrescentar();
acrescentar.Exibir(0);



            }
      
    }

class Program
{
    static void Main (string [] args)
    {

Console.WriteLine("\nCarro:\n ");
Carro carro = new Carro();
carro.ExibirCarro("Toyota\n", "Corolla\n", 2020);

Console.WriteLine("\nMoto:\n ");
Moto moto = new Moto();
moto.ExibirMoto("Honda\n", "Civic\n", 2022);
    }
}


class Livro{
public String Titulo {get; set;}
public String Autor{get; set;}
public int AnoPublicacao{get; set;}


}

public class CadastroDeLivros
{

    public void CadastrarLivro (string titulo, string autor, int ano)
    {
       Livro informacoes = new Livro{
        Titulo = titulo,
            Autor = autor,
            AnoPublicacao = ano
       };
            
        

    }
  
    public void ExibirLivro(){
          Livro informacoes = new Livro ();
        Console.WriteLine($"Título: {informacoes.Titulo}\n autor: {informacoes.Autor}\n ano: {informacoes.AnoPublicacao}");
    }
}

class Program{
    static void Main (string [] args)
    {

//solicitação de dados
string autor, titulo; int ano;
Console.WriteLine($"preencha os dados de um livro.");
Console.Write($"Título: ");
titulo = Console.ReadLine();
Console.Write($"Autor: ");
autor = Console.ReadLine();
Console.Write($"Ano: ");
ano = Convert.ToInt32(Console.ReadLine());

//instanciação
CadastroDeLivros cadastro = new CadastroDeLivros();
cadastro.CadastrarLivro(titulo, autor, ano);

//mostrar dados
cadastro.ExibirLivro();
    }
}
public struct Retangulo
{
double altura;
double largura;
public double formula;
public void CalcularArea(double altura, double largura)
{
this.altura = altura;
this.largura = largura;

formula = (altura * largura);

}

public void CalcularPerimetro(double altura, double largura)
{
    this.altura = altura;
    this.largura = largura;

formula = 2*(altura + largura);
}

}

class Program{
    static void Main (string [] args)
    {

        //dados
        double altura;
        double largura;
        Console.Write("Digite a altura do retângulo: ");
        altura = double.Parse(Console.ReadLine());
         Console.Write("Digite a largura do retângulo: ");
        largura = double.Parse(Console.ReadLine());
Console.Clear();
        //instanciando área
        Retangulo area = new Retangulo();
        area.CalcularArea(altura, largura);
             Console.WriteLine($"\n Área do retângulo: {area.formula}\n");
        

          //instanciando PERÍMETRO
          Retangulo perimetro = new Retangulo();
          perimetro.CalcularPerimetro(altura, largura);
          
           Console.WriteLine($"\n Perímetro do retângulo: {perimetro.formula}\n");
       

    }
}
    public interface IAnimal
    {
       void EmitirSom();
       void Movimenntar();
      
    }

    public class Cachorro : IAnimal
    {

        
 public void EmitirSom(){

Console.WriteLine("O cachorro faz: Au au!");
  }

       public void Movimenntar(){
        Console.WriteLine("O cachorro está correndo.");

        }
      
    }

        public class Gato : IAnimal
    {
        
 public void EmitirSom(){
Console.WriteLine("O gato faz: Miau!");
  }
       public void Movimenntar(){
Console.WriteLine("O gato está saltando.");
        }
      
    }

        public class Pássaro : IAnimal
    {
        
 public void EmitirSom(){
Console.WriteLine("O pássaro faz: Piu piu!");
  }
       public void Movimenntar(){
Console.WriteLine("O pássaro está voando.");
        }

    }
class Program
{
    
    static void Main(string[] args)
    {

      
começo:
        int escolha;
        //escolha
Console.WriteLine("Qual animal deseja escolher, Cachorro[1], Gato[2] ou Pássaro[3]?");
escolha = int.Parse(Console.ReadLine());

//condição:
if (escolha == 1)
{
  //cachorro
IAnimal cachorro = new Cachorro();
cachorro.EmitirSom();
cachorro.Movimenntar();

    Console.WriteLine("Gostaria de voltar ao início? [s/n]");
    char EscolhaFinal1 = char.Parse(Console.ReadLine());

    if (EscolhaFinal1 == 'S' || EscolhaFinal1=='s')
    {
        Console.Clear();
goto começo;
    } else 
    {
        Console.WriteLine("Bye!");
        Console.Clear();
    }
} else if (escolha == 2)
{
      //gato
IAnimal gato = new Gato();
gato.EmitirSom();
gato.Movimenntar();

    Console.WriteLine("Gostaria de voltar ao início? [s/n]");
    char EscolhaFinal2 = char.Parse(Console.ReadLine());

    if (EscolhaFinal2 == 'S' || EscolhaFinal2=='s')
    {
        Console.Clear();
goto começo;
    } else 
    {
        Console.WriteLine("Bye!");
        Console.Clear();
    }
} else if (escolha == 3)
{
 //pássaro
IAnimal passaro = new Pássaro();
passaro.EmitirSom();
passaro.Movimenntar();

    Console.WriteLine("Gostaria de voltar ao início? [s/n]");
    char EscolhaFinal3 = char.Parse(Console.ReadLine());

    if (EscolhaFinal3 == 'S' || EscolhaFinal3=='s')
    {
        Console.Clear();
goto começo;
    } else 
    {
        Console.WriteLine("Bye!");
        Console.Clear();
    }
} else 
{
    Console.WriteLine("Gostaria de voltar ao início? [s/n]");
    char EscolhaFinal = char.Parse(Console.ReadLine());

    if (EscolhaFinal == 'S' || EscolhaFinal=='s')
    {
        Console.Clear();
goto começo;
    } else 
    {
        Console.WriteLine("Bye!");
        Console.Clear();
    }
}


     
    }
}



    public interface IPagamento {
        void ProcessarPagamento(double valor);
void Exibir();
    }

    public class CartaodeCredito : IPagamento {
        
public double valor;
        public void ProcessarPagamento(double valor) {
            
            this.valor = valor;
        
        }

     public   void Exibir (){
           
          
            Console.WriteLine($"Pagamento de {valor} realizado com sucesso no Cartão de Crédito.\n \n Recibo: Pagamento efetuado via Cartão de Crédito.\n");
          
        }
    }

       public class Pix : IPagamento{
        double valor;
        public void ProcessarPagamento(double valor) {
            
            this.valor = valor;
        
        }

       public  void Exibir (){
      
            
          
            Console.WriteLine($"Pagamento de {valor} realizado com sucesso.\n Recibo: Pagamento efetuado via Pix.\n");
          
        }
       }
public class Program
{
    static void Main(string[] args)
    {
       
      
      
        IPagamento pagamento = new CartaodeCredito();
              Console.WriteLine("Digite o valor do pagamento:");
                CartaodeCredito cartao = new CartaodeCredito();
                       double valor = Convert.ToDouble(Console.ReadLine());
                cartao.ProcessarPagamento(valor);
        pagamento.ProcessarPagamento(valor);
    Console.WriteLine("Deseja realizar o pagamento via Pix ou Cartão de Crédito? [C] ou [P].");
                var resposta = Char.Parse(Console.ReadLine());

                Pix pix = new Pix();
pix.ProcessarPagamento(valor);
                
                if (resposta == 'C' || resposta =='c')
                {
                  
                    cartao.Exibir();

                } else if (resposta == 'P' || resposta == 'p')
                {
pix.Exibir();
                }



    }
}

  

   public class Aluno
{
    private int[] nota = new int[6];

    public int this[int i]
    {
        get
        {
            return nota[i];
        }
        set
        {
            if (i < 0 || i >= nota.Length)
            {
                Console.WriteLine("Erro. O índice está fora do intervalo.");
            }
            else if (value < 0 || value > 10)
            {
                Console.WriteLine("Erro. A nota não pode ser menor que 0 ou maior que 10.");
            }
            else
            {
                nota[i] = value;
            }
        }
    }

    public void exibir()
    {
        foreach (int notas in nota)
        {
            Console.WriteLine(notas);
        }
    }
}
public class Program
{

  

    static void Main(string[] args)
    {
      List<int> numeros = new List<int>{};
     Aluno aluno = new Aluno();
     
     for (int i = 0; i < 6; i++)
     {
        Console.Write($"Digite a {i + 1} nota: ");
aluno[i] = Convert.ToInt32(Console.ReadLine());
numeros.Add(aluno[i]);
     }

    aluno.exibir();
    
     
     
     
          
    } 
}
   

public class Pessoa
{
    private string _nome;
    private int _idade; 
    private double _altura;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public int idade
    {
        get { return _idade; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Erro. A idade não pode ser menor que 0.");
            }
            else if (value > 120)
            {
                Console.WriteLine("Erro. A idade nao pode ser maior que 120.");
            }
            else
            {
                _idade = value;
            }
        }
    }

    public double altura
    {
        get { return _altura; }
        set
        {
            if (value < 0.5)
            {
                Console.WriteLine("Erro: A altura não pode ser menor que 0.5 metros.");
            }
            else if (value > 2.5)
            {
                Console.WriteLine("Erro: A altura não pode ser maior que 2.5 metros.");
            }
            else
            {
                _altura = value;
            }
        }
    }

    public void exibir()
    {
        Console.WriteLine($" \nNome: {Nome}\n Idade: {idade}\n Altura: {altura}\n");
    }
}

    abstract class FormaDePagamento
    {
        public abstract void EfetuarPagamento(double valor);
    }

    class PagamentoDinheiro : FormaDePagamento
    {
        public override void EfetuarPagamento(double valor)
        {
            Console.WriteLine($"Você pagou R$ {valor:F2} em dinheiro físico.");
        }
    }

    class PagamentoCartaoCredito : FormaDePagamento
    {
        public int Parcelas { get; set; }

        public override void EfetuarPagamento(double valor)
        {
            double valorParcela = valor / Parcelas;
            Console.WriteLine($"Você parcelou R$ {valor:F2} em {Parcelas}x de R$ {valorParcela:F2} no cartão de crédito.");
        }
    }

    class PagamentoPix : FormaDePagamento
    {
        public override void EfetuarPagamento(double valor)
        {
            Random random = new Random();
            string chavePix = "81 9" + string.Concat(Enumerable.Range(0, 8).Select(_ => random.Next(0, 10)));
            Console.WriteLine($"Chave PIX gerada: {chavePix}");
            Console.WriteLine($"Você pagou R$ {valor:F2} via PIX.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 10.0; // Valor fixo da compra

            while (true)
            {
                Console.WriteLine("\nEscolha a forma de pagamento:");
                Console.WriteLine("1 - Pagamento em Dinheiro");
                Console.WriteLine("2 - Pagamento com Cartão de Crédito");
                Console.WriteLine("3 - Pagamento via PIX");
                Console.Write("Opção: ");

                if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > 3)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue;
                }

                FormaDePagamento pagamento;
                switch (escolha)
                {
                    case 1:
                        pagamento = new PagamentoDinheiro();
                        break;

                    case 2:
                        pagamento = new PagamentoCartaoCredito();
                        Console.Write("Em quantas parcelas deseja pagar? ");
                        if (int.TryParse(Console.ReadLine(), out int parcelas) && parcelas > 0)
                        {
                            ((PagamentoCartaoCredito)pagamento).Parcelas = parcelas;
                        }
                        else
                        {
                            Console.WriteLine("Número de parcelas inválido! Voltando ao menu...");
                            continue;
                        }
                        break;

                    case 3:
                        pagamento = new PagamentoPix();
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        continue;
                }

                pagamento.EfetuarPagamento(valorCompra);

                Console.Write("\nDeseja realizar outra compra? (S/N): ");
                char continuar = Console.ReadKey().KeyChar;
                if (char.ToUpper(continuar) != 'S')
                {
                    Console.WriteLine("\nObrigado pela preferência!");
                    break;
                }

                Console.Clear();
            }
        }
    }

namespace Efraim    
{

abstract class Formadepagamento 
{

abstract public void EfetuarPagamento(double valor);

}
class PagamentoDinheiro : Formadepagamento
{
public int valor, dinheiro,seudinheiro;
public override void EfetuarPagamento(double valor)
{
   this.valor = (int)valor;
    Console.WriteLine($"você deu R$ {seudinheiro},00 e sobrou {dinheiro - valor}.\n");
}

}

class PagamentoCartaoCredito : Formadepagamento
{
    public int valor, dinheiro,seudinheiro;
public override void EfetuarPagamento(double valor)
{
Console.WriteLine($"você terá que pagar 2x de {(float)(valor /2)}.\n");
}
}

class PagamentoPix : Formadepagamento
{
public override void EfetuarPagamento(double valor)
{

}

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nSupunhetamos que você esteja com sede e decide comprar uma água em um estabelecimento.\nApós entrar lá você se depara com as seguintes opções de água:\n");
int gelada = 2; int gas = 10; int proteina = 20; int seudinheiro = 20;

        Console.WriteLine($" 1.... Água gelada - R$ {gelada},00\n 2.... Água com gás - R$ {gas},00\n 3.... Água com proteína - R$ {proteina},00\n");
        Console.Write($"Você tem R$ {seudinheiro},00, um carão de crédito e pix.\n Qual opção você deseja escolher? (escolha o número equivalente ao produto):\n ");
     int opcao = int.Parse(Console.ReadLine());
      
          
     switch (opcao)
     {
        case 1: opcao = 1;
        Console.WriteLine("QUal opção de pagamento você deseja solicitar?\n 1.... Pagamento em dinheiro\n 2.... Pagamento com cartão de crédito\n 3.... Pagamento com pix");
         int opcaopagamento = int.Parse(Console.ReadLine());
         switch (opcaopagamento)
{
    case 1: opcaopagamento = 1;

PagamentoDinheiro dinheiro = new PagamentoDinheiro{
dinheiro = seudinheiro,
seudinheiro = seudinheiro
};
dinheiro.EfetuarPagamento(gelada);

    break;

    case 2: opcaopagamento = 2; 
    Console.WriteLine("A loja só parcela em 2x.\n");
    
PagamentoCartaoCredito cartao = new PagamentoCartaoCredito{
    dinheiro = seudinheiro,
seudinheiro = seudinheiro

};
cartao.EfetuarPagamento(gelada);
    break;

    case 3: opcaopagamento = 3;
    Console.WriteLine("Pagamento com pix em desenvolvimento");
    
    break;
}

        break;

        case 2: opcao = 2;
        Console.WriteLine("Voce escolheu a agua com gás");
        break;

        case 3:
        Console.WriteLine("Voce escolheu a agua com proteína");
        break;

        default:
        Console.WriteLine("Opção invalida");
        break;
    }
    }
}


}

abstract class Veiculo
{
abstract public void Mover();
}

 class Carro : Veiculo
{
override public void Mover(){
    Console.WriteLine("O carro se move");
}
} 
class Aviao : Veiculo{

override public void Mover(){
    Console.WriteLine("\nO avião se move");
}
    
}

abstract class Funcionario
{

abstract public void CalcularSalario();
}

class FuncionarioHora : Funcionario
{
public int valorhora;
public int horastrabalhadas;

override public void CalcularSalario()
{

int diária = (valorhora * horastrabalhadas);
int salario = diária * 24;
Console.WriteLine($"\nSalário diário no final do mês: {salario}");
}
}

class FuncionarioMensal : Funcionario
{
public int valorfixo;
override public void CalcularSalario()
{
Console.WriteLine($"Salário fixo: {valorfixo}\n");
}
    
}


class Program
{
    static void Main(string[] args)
    {
        //primeiro exercício:
Aviao aviao = new Aviao();
aviao.Mover();
Carro carro = new Carro ();
carro.Mover();

  //segundo exercício:
        FuncionarioHora funcionarioHora = new FuncionarioHora
        {
           valorhora = 10,
           horastrabalhadas = 8
        };
      
        funcionarioHora.CalcularSalario();

        FuncionarioMensal funcionarioMensal = new FuncionarioMensal();
        funcionarioMensal.valorfixo = 5000;
        funcionarioMensal.CalcularSalario();
    }
}


    public class Animal{
         virtual public void emitirsom(){
            Console.WriteLine("Este é o som de um animal genérico.");
        }
    }

    public class Gato : Animal{
            public override void emitirsom(){
            Console.WriteLine("\nGato: miau miau miaupika\n");
             for (int i = 1; i <= 10; i++){
                Console.WriteLine($"{i} posição");
            }
        }
    }

    public class Cachorro : Animal{
            public override void emitirsom(){
            Console.WriteLine("\nCachorro: Au au au cacete!\n");
           
        }
    }
     public class Pato : Animal{
            public override void emitirsom(){
            Console.WriteLine("\nPato: quack quack manos\n");
        }
    }
    
public class Program
{

    static void Main(string[] args)
    {
        Animal Ref;
        Gato gato = new Gato();
          Ref = gato;
        Ref.emitirsom();
        Cachorro cachorro = new Cachorro();
          Ref = cachorro;
        Ref.emitirsom();
        Pato pato = new Pato();
        Ref = pato;
        Ref.emitirsom();
        
    }
}


public class Base
{

virtual public void Exibir()
{
    Console.WriteLine($"xvideos");
}


}

public class Copiar : Base
{


override public void Exibir()
{
    Console.WriteLine($"PornHub");
}
}


public class Copiar2 : Copiar
{


override public void Exibir()
{
    Console.WriteLine($"Xhamster");
}
}


    class Program
    {
        static void Main(string[] args)
        {
            
            Base Ref;
         
            Copiar copiar = new Copiar();
            Copiar2 copiar2 = new Copiar2();
        
            Ref = copiar;
            Ref.Exibir();
            Ref = copiar2;
            Ref.Exibir(); 
    
           
        }
    }


{

    class Veiculo
    {
protected int velatual;
public string nome;
public void Nome(string nome)
{
this.nome=nome;
}

public void exibir()
{
Console.WriteLine($"velocidade atual: {velatual}km/h");
Console.WriteLine($"nome: {nome}");
}

public void exibir2()
{

Console.WriteLine($"nome: {nome}");
}

public void acelerando ()
{
    Console.WriteLine($"acelerando em: {velatual}km/h");
}


public void aumentavel(int aumento)
{
velatual = 0;
velatual += aumento;

}
    }

    class Carro : Veiculo
    {


public void Acelerar(int aumentavel) 
{
  
    base.aumentavel(aumentavel);


}

    }

    class Bicicleta : Veiculo
    {



public void Acelerar(int aumentavel) 
{

    base.aumentavel(aumentavel);
}
    }

    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("carro:\n");
            Carro carro = new Carro();
          for (int i = 0; i <= 100; i+=20)
          {

carro.exibir();
if (i == 100)
{

break;
}
  Console.WriteLine($"acelerando em {i}km/h...");
  carro.Acelerar(i);
          }


Console.WriteLine("\nbicicleta:\n");
            Bicicleta bicicleta = new Bicicleta();
            Veiculo nome = new Veiculo();
            nome.Nome("atumalakaka");
        nome.exibir();
          for (int i = 0; i <= 50; i+=10)
          {

bicicleta.exibir();
if (i == 50)
{

break;
}
  Console.WriteLine($"acelerando em {i}km/h...");
  bicicleta.Acelerar(i);
          }

        }
        
    }
}
/*

{

    public class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("O animal faz um som.");
    }
}
public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}

public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}

    public class Funcionario
    {
        public string nome;
        public int salario;

        public Funcionario(string nome, int salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome}\nSalário: {salario}");
        }
    }

    public class Gerente : Funcionario
    {
        public string departamento;

        public Gerente(string nome, int salario, string departamento)
            : base(nome, salario)
        {
            this.departamento = departamento;
        }

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Departamento: {departamento}");
        }
    }

    public class Estagiario : Funcionario
    {
        public int horasTrabalhadas;

        public Estagiario(string nome, int salario, int horasTrabalhadas)
            : base(nome, salario)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Horas Trabalhadas: {horasTrabalhadas}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nGerente:\n");
            Gerente gerente = new Gerente("Efraim", 3840, "TI");
            gerente.Exibir();

            Console.WriteLine("\nEstagiário:\n");
            Estagiario estagiario = new Estagiario("Eduardo", 2400, 8);
            estagiario.Exibir();

            Animal meuAnimal = new Animal();
        meuAnimal.Falar(); // Saída: O animal faz um som.

        Animal meuCachorro = new Cachorro();
        meuCachorro.Falar(); // Saída: O cachorro late: Au Au!

        Animal meuGato = new Gato();
        meuGato.Falar(); // Saída: O gato mia: Miau!
        }
    }
}


    
/*
    using System.Diagnostics.Contracts;

class exemplo
{
    public int exemplo1;
   

    public void estruturar(out int a, out int b)
    {
    
        a = 0;
        b = 0;
exemplo1 = a+b;

    }

    public void atribuir ()
    {
   Console.WriteLine(exemplo1);

    }

}
    public static class Jogos
{

static  int ano;
static string nome;

public static void spiderman(int a, string n)
{
    ano = a;

    nome = n;
}

public static void godofwar(int a, string n)
{
     ano = a;
    nome = n;
    
}

public static void exibir()
{
    Console.WriteLine($"O jogo {nome} foi lancado em {ano}");
}

}

class Program{


public static void Main(string[] args)  
{
  
   exemplo exemplo = new exemplo();
   exemplo.estruturar(out int a, out int b);
   exemplo.atribuir();
    Jogos.spiderman(2021, "spiderman");
    Jogos.exibir();
    Jogos.godofwar(2021, "godofwar");
    Jogos.exibir();

}
}



class Produto
{

    private double preco;
    private string nome;

    public string Getnome (string nome)
    {

      
        return nome;

    }
        public static void Setnome (string nome)
    {








    }

        public int Getpreco (double preco)
    {
        this.preco = preco;
return (int)preco;

if (preco < 0)
{
Console.WriteLine("preco nao pode ser negativo");
} else 
{
Console.WriteLine(preco);
}
    }

        public static void Setpreco ()
    {

    }

    
}

class program 
{


       public static void Main(string[] args)
        {
string fds = Convert.ToString(Console.ReadLine());
double fds2 = Convert.ToInt32(Console.ReadLine());
            Produto produto = new Produto();
           
           Console.WriteLine( produto.Getnome(fds));
            Console.WriteLine(produto.Getpreco(fds2));
       
        }

     
}


class ContaBancária
{

    string titular;
    double saldo;

   public ContaBancária(string titular, double saldo)
    {
        this.titular = titular;
        this.saldo = saldo;

    }

    public void depositar()
    {
        
    
 Console.WriteLine("Quanto deseja depositar?");
        int depositarr = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"{titular}, agora você tem {saldo+ depositarr}R$");
    
    }

    public void sacar()
    {
        Console.WriteLine("Quanto deseja sacar?");
        int sacar = Convert.ToInt32(Console.ReadLine());
        if (sacar <= saldo)
        {
            
            Console.WriteLine($"{titular}, agora você tem {saldo- sacar}R$");
        } else { Console.WriteLine("saldo insuficiente"); }
    }

    public void exibir ()
    {
         Console.WriteLine($"{titular}, {saldo}");
    }

    public static void Main(string[] args)
    {

        
          ContaBancária saldos = new ContaBancária("efrai", 1000);
        Console.WriteLine("Você quer sacar ou depositar? Digite S para sacar e D para depositar");
        char escolha = Convert.ToChar(Console.ReadLine());
        if (escolha == 'S' || escolha == 's') 
        {
  saldos.sacar();
        } else if (escolha == 'D' || escolha == 'd')
        {
saldos.depositar();
        }


     
      
      
    }
}





static class Calculadora
{
    public static int Soma(int a, int b)
    {
        return a + b;
    }

    public static int Subtracao(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicacao(int a, int b)
    {
        return a * b;
    }

    public static string Divisao(int a, int b)
    {
        if (b == 0)
        {
            return "Erro: Não é possível dividir por zero.";
        }
        return (a / (double)b).ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite dois números: ");
        int um = Convert.ToInt32(Console.ReadLine());
        int dois = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A soma é: " + Calculadora.Soma(um, dois));
        Console.WriteLine("A subtração é: " + Calculadora.Subtracao(um, dois));
        Console.WriteLine("A multiplicação é: " + Calculadora.Multiplicacao(um, dois));
        
        string resultadoDivisao = Calculadora.Divisao(um, dois);
        Console.WriteLine("A divisão é: " + resultadoDivisao);
    }
}

   





        static string Título;
        static string Autor;
        static string Preço;


        static void livro(string t, string a, string p)
        {
            Título = t;
            Autor = a;
            Preço = p;


        }
        static void ExibirInfo()
        {



            Console.WriteLine($"título: {Título}\n autor: {Autor}\n preço: {Preço}");


        }

          static void Main()
        {


            Livro.livro("O Senhor dos Anais", "JBL Tolkien", "R$ 69,00");
            Livro.ExibirInfo();
        }






class Livro
{


   public string Título; 
public string Autor; 
public string Preço;

public Livro(string t, string a, string p)
{
 Título = t;
 Autor = a;
 Preço = p;

}
public void ExibirInfo()
{
        Console.Clear();

Console.WriteLine($"título: {Título}\n autor: { Autor}\n preço: { Preço}");

}
}

class Program{

public static void Main(string[] args)
{
 Livro livro = new Livro("O Senhor dos Aneis", "JRR Tolkien", "R$ 50,00");
livro.ExibirInfo();
}
}




/*

class Carro
{
    public int Ano;
    public string Modelo;
    public string Marca;
    public double VelocidadeAtual;

    static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.Ano = 2020;
        carro.VelocidadeAtual = 0;

        carro.ExibirInfo();

        Console.WriteLine("Acelerando...");
        carro.Acelerar(100);

        Console.WriteLine("Freiando...");
        carro.Frear();
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Carro de {Marca}, {Modelo}, lançado em {Ano}, velocidade atual {VelocidadeAtual}km/h.");
    }

    public void Acelerar(double novaVelocidade)
    {
        for (int i = (int)VelocidadeAtual; i <= (int)novaVelocidade; i++)
        {
            VelocidadeAtual = i;
            Console.WriteLine($"Velocidade atual: {VelocidadeAtual}km/h");
        }
        ExibirInfo();
    }

    public void Frear()
    {
        for (int i = (int)VelocidadeAtual; i >= 0; i--)
        {
            VelocidadeAtual = i;
            Console.WriteLine($"Velocidade atual: {VelocidadeAtual}km/h");
        }
        ExibirInfo();
    }
   
}





class Program
{
    
}

class Filme
{
    public string Genero;
    public int Ano;

    public void ExibirInfo()
    {
        Console.WriteLine($"Filme de {Genero}, lançado em {Ano}.");
    }
}


class Generos
{
    public static void Ficcao()
    {
        Filme genero1 = new Filme();
        genero1.Genero = "Ficção";
        genero1.Ano = 2000;
        genero1.ExibirInfo();
    }

    public static void Romance()
    {
        Filme genero2 = new Filme();
        genero2.Genero = "Romance";
        genero2.Ano = 2010;
        genero2.ExibirInfo();
    }

    public static void Acao()
    { 

        int fds;

        Filme genero3 = new Filme();
        genero3.Genero = "Ação";
        genero3.Ano = 2015;
        genero3.ExibirInfo();

        
    }

    public static void Comedia()
    {
        Filme genero4 = new Filme();
        genero4.Genero = "Comédia";
        genero4.Ano = 2020;
        genero4.ExibirInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Generos.Ficcao();
        Generos.Romance();
        Generos.Acao();
        Generos.Comedia();
    }
}
*/

