using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscrevendoNoCelular;
using System;

namespace CelularTestes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConversaoLetrasNumerosCASA()
        {
            Celular teste = new Celular("CASA");
            Assert.AreEqual("222_277772", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosABC_DEF_GHI()
        {
            
            Celular teste = new Celular("ABC DEF GHI");
            Assert.AreEqual("2_22_22203_33_33304_44_444", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosJKL_MNO()
        {
            Celular teste = new Celular("JKL MNO");
            Assert.AreEqual("5_55_55506_66_666", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosPQRS()
        {
            Celular teste = new Celular("PQRS");
            Assert.AreEqual("7_77_777_7777", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosTUV_WXYZ()
        {
            Celular teste = new Celular("TUV WXYZ");
            Assert.AreEqual("8_88_88809_99_999_9999", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumeros123()
        {
            Celular teste = new Celular("123");
            Assert.AreEqual("Mensagem Inválida", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosAcentos()
        {
            Celular teste = new Celular("`~´");
            Assert.AreEqual("Mensagem Inválida", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumerosSEMPRE_ACESSO_O_DOJOPUZZLES()
        {
            Celular teste = new Celular("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", teste.ConverteMensagemEmNumero());
        }

        [TestMethod]
        public void ConversaoLetrasNumeros255Caracteres()
        {
            Celular teste = new Celular("AtxTkDieVhADZncLGRCexsNVlrmisVubJXFeTDYkxrxSQzDZWYAtxTkDieVhADZncLGRCexsNVlrmisVubJXFeTDYkxrxSQzDZWYAtxTkDieVhADZncLGRCexsNVlrmisVubJXFeTDYkxrxSQzDZWYAtxTkDieVhADZncLGRCexsNVlrmisVubJXFeTDYkxrxSQzDZWYAtxTkDieVhADZncLGRCexsNVlrmisVubJXFeTDYkxrxSQzDZWYAAAAAAAAAAAAAAA");
            Assert.AreEqual("Mensagem Inválida", teste.ConverteMensagemEmNumero());
        }
    }
}
