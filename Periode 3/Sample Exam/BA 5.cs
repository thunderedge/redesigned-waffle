using System;
2
using System.Diagnostics;
3
using System.Threading;
4
5
namespace Test
6
{
7
  class Program
8
  {
9
    public static void Main(string[] args)
10
    {
11
      
var
 
PlayingCards
 = 
new
 
PlayingCard[]
{
12
        new PlayingCard("Pikacha", 4, 3),
13
        new PlayingCard("Eeve", 4, 7),
14
        new PlayingCard("Dons", 6, 4),
15
        new PlayingCard("Charizark", 8, 2),
16
        new PlayingCard("Charminder", 8, 4),
17
        new PlayingCard("Snorlap", 1, 9),
18
        new PlayingCard("Dippo", 1, 2),
19
        new PlayingCard("Squtile", 1, 5)
20
      };
21
22
      
var
 deck = 
new Tuple<PlayingCard, int[]>
 {
23
        Tuple.Create(playingCards[0], 1),
24
        Tuple.Create(playingCards[2], 3),
25
        Tuple.Create(playingCards[3], 2),
26
        Tuple.Create(playingCards[5], 3),
27
        Tuple.Create(playingCards[7], 1),
28
      };
29
30
      
var
 d = 
new Deck("Deck 1", deck)
;
31
32
      var x = d.ListsDeck();
33
      var y = d.MakeFullDeck();
34
    }
35
  }
36
37
  public class Deck
38
  {
39
    public string name;
40
    public Tuple<PlayingCard, int>[] PlayingCards;
41
42
    public Deck(string name, Tuple<PlayingCard, int>[] PlayingCards)
43
    {
44
      this.name = name;
45
      this.PlayingCards = PlayingCards;
46
    }
47
48
    public 
int
 CountPlayingCards()
49
    {
50
      int count = 0;
51
      for (int i = 0; i < this.PlayingCards.Length; i++)
52
      {
53
        count = count + this.
PlayingCards[i]
.
Item2
;
54
      }
55
      return count;
56
    }
57
58
    public 
string
 ListsDeck()
59
    {
60
      string cardList = "Cards in deck:\n";
61
      for (int i = 0; i < this.PlayingCards.Length; i++)
62
      {
63
        cardList = cardList + 
this
.
PlayingCards[i]
.
Item1.name
 + " x " + 
this
.
PlayingCards.Item2
 + "\n";
64
      }
65
      return cardList;
66
    }
67
68
    public 
PlayingCard[]
 MakeFullDeck()
69
    {
70
      int size = 
this.CountPlayingCards()
;
71
      int index = 0;
72
      PlayingCard[] fullDeck = new PlayingCard[
size
];
73
      for (int i = 0; i < this.PlayingCards.
Length
; i++)
74
      {
75
        for (int j = 0; j < this.PlayingCards[i].
Item2
; j++)
76
        {
77
          fullDeck[index] = this.PlayingCards[i].
Item1
;
78
          
index++
;
79
        }
80
      }
81
      return fullDeck;
82
    }
83
  }
84
}
85
86
public class PlayingCard
87
{
88
  public string name;
89
  public int hp;
90
  public int attackPoints;
91
92
  public 
PlayingCard
(string name, int hp, int attackPoints)
93
  {
94
    this.name = 
name
;
95
    this.hp = 
hp
;
96
    this.attackPoints = 
attackPoints
;
97
  }
98
}
