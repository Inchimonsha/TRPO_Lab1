﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Var12Организация организация)
        {
            Console.WriteLine($"организация.Название = {организация.Название}");
            Console.WriteLine($"организация.Юридическийадрес = {организация.Юридическийадрес}");
            Console.WriteLine($"организация.Фактическийадрес= {организация.Фактическийадрес}");
            Print(организация.Руководитель);
        }

        public static void Print(Var5Студент Студент)
        {
            Console.WriteLine($"Студент.Фамилия = {Студент.Фамилия}");
            Console.WriteLine($"Студент.Имя = {Студент.Имя}");
            Console.WriteLine($"Студент.Отчество = {Студент.Отчество}");
            Print(Студент.Группа);
            Console.WriteLine($"Студент.ДатаРождения = {Студент.ДатаРождения}");
        }
        public static void Print(Var4Группа группа)
        {
            Console.WriteLine($"Группа.Название = {группа.Название}");
            Console.WriteLine($"Группа.сокращение = {группа.Сокращение}");
            Console.WriteLine($"Группа.численность = {группа.Численность}");
            Console.WriteLine($"Группа.год поступление = {группа.ГодПоступления}");
            Print(группа.КлассныйРуководитель);
            Print(группа.Специальность);
        }
        public static void Print(Var6Специальность cпециальность)
        {

        }
        public static void Print(Var15Оборудование оборудование)
        {

        }
        public static void Print(Var8Смена смена)
        {
            Console.WriteLine($"Var8Смена Название = {смена.Название}");
        }
        public static void Print(Var9Сотрудники сотрудники)
        {

        }
        public static void Print(Var3Дисциплина Дисциплина)
        {
            Console.WriteLine($"Var3Дисциплина Название = {Дисциплина.Название}");
            Console.WriteLine($"Var3Дисциплина Сокращение = {Дисциплина.Сокращение}");
        }
        public static void Print(Var2Аудитория аудитория)
        {
            Console.WriteLine($"Аудитория.НазваниеАудитории={аудитория.НазваниеАудитории}");
            Print(аудитория.Сотрудники);
            Console.WriteLine($"Аудитория.КоличествоМест={аудитория.КоличествоМест}");
            Console.WriteLine($"Аудитория.КоличествоОкон={аудитория.КоличествоОкон}");
            Print(аудитория.Оборудование);
        }

        public static void Print(Var10Должность должность)
        {
            Console.WriteLine($"Должность.Название = {должность.Название}");
            Console.WriteLine($"Должность.Оклад = {должность.Оклад}");
            Print(должность.Подразделение);
        }
        public static void Print(Var11Подразделение подразделение)
        {
            Console.WriteLine($"Var12Подразделение НазваниеПодразделения = {подразделение.Названиеподразделения}");
            Print(подразделение.Сотрудники);
            Print(подразделение.Организация);
        }

        public static void Print(Var7Пара пара)
        {
            Console.WriteLine("Время начала пары = " + (пара.ЧасыНачалаПары < 10 ? "0" : "") + пара.ЧасыНачалаПары + ":" + (пара.МинутыНачалаПары < 10 ? "0" : "") + пара.МинутыНачалаПары);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыКонцаПары < 10 ? "0" : "") + пара.ЧасыКонцаПары + ":" + (пара.МинутыКонцаПары < 10 ? "0" : "") + пара.МинутыКонцаПары);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыНачалаПерерыва < 10 ? "0" : "") + пара.ЧасыНачалаПерерыва + ":" + (пара.МинутыНачалаПерерыва < 10 ? "0" : "") + пара.МинутыНачалаПерерыва);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыКонцаПерерыва < 10 ? "0" : "") + пара.ЧасыКонцаПерерыва + ":" + (пара.МинутыКонцаПерерыва < 10 ? "0" : "") + пара.МинутыКонцаПерерыва);
            Print(пара.Смена);
        }
    }
}
