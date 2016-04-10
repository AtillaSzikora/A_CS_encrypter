//Encrypts a given text by changing each character to the following letter in the alphabet. Can also decrypt.

using System;

internal class Encrypter {
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private const string TextPattern = "N"; //N is 13th char from the 25 long alphabet (...counted from 0)

	private static string Encrypt(string textToEncrypt) {
        var encryptedText = "";
		foreach (var c in textToEncrypt) {
			if (Alphabet.IndexOf(char.ToUpper(c)) != -1) {
				encryptedText += Alphabet[Alphabet.IndexOf(char.ToUpper(c))*2 - 26]; }
			else { encryptedText += c; } }
		return encryptedText; }

	private static string Decrypt(string textToDecrypt) {
        var decryptedText = "";
		foreach (var c in textToDecrypt) {
			if (Alphabet.IndexOf(char.ToUpper(c)) != -1) {
				decryptedText += Alphabet[Alphabet.IndexOf(char.ToUpper(c)) / 2]; }
			else { decryptedText += c; } }
		return decryptedText; }

	private static void Main(string[] args) {
        Console.WriteLine("Text to encrypt: " + TextPattern + "\tEncrypted text: " + Encrypt(TextPattern));
        Console.WriteLine("Text to decrypt: " + Encrypt(TextPattern) + "\tDecrypted text: " + Decrypt(Encrypt(TextPattern))); }
}