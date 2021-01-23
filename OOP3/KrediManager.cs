using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //interface'ler I harfi ile başlatılır okunması kolay olması için
    {
        /*interface'in içindeki operasyonlar alternatif sistemler için bir şablon ve referans tutucu görevi görür.
        birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız */
        void Hesapla();
        void BiseyYap();
    }
}
