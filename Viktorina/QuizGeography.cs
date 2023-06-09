﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Viktorina
{
    public class QuizGeography 
    {
        public string[] questions;
        public string[][] answers;
        public int[] correctAnswers;
        public int bal;

        public QuizGeography()
        {
            string[] lines = File.ReadAllLines("questionsGeography.txt", Encoding.GetEncoding(1251));
            int num = int.Parse(lines[0]);
            questions = new string[num];
            answers = new string[num][];
            correctAnswers = new int[num];

            int index = 1; //строки
            for (int i = 0; i < num; i++)
            {
                questions[i] = lines[index++];
                answers[i] = lines[index++].Split(',');
                correctAnswers[i] = int.Parse(lines[index++]);
            }
        }
        public void RunG()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                for (int j = 0; j < answers[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {answers[i][j]}");
                }
                Console.Write("Выберите вариант ответа: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswers[i])
                {
                    Console.WriteLine("Правильно!");
                    bal++;
                }
                else
                {
                    Console.WriteLine("Неправильно.");
                }
            }
            Console.WriteLine($"Вы набрали {bal} из {questions.Length} баллов.");
            Console.ReadLine();
        }
    }
}

