﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace FasterHashing
{
    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.0 libraries, using libssl
    /// </summary>
    internal static class InteropOpenSSL10_libssl
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl";

        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_create();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_cleanup(IntPtr ctx);

        /// <summary>
        /// Destroys (frees) the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_destroy(IntPtr ctx);

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Loads all known digest methods, should be called on initialization
        /// </summary>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void OpenSSL_add_all_digests();

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Ansi)]
        public extern static IntPtr SSLeay_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.0 libraries, using libssl.so.1.0
    /// </summary>
    internal static class InteropOpenSSL10_libssl_so_1_0
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl.so.1.0";

        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_create();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_cleanup(IntPtr ctx);

        /// <summary>
        /// Destroys (frees) the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_destroy(IntPtr ctx);

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Loads all known digest methods, should be called on initialization
        /// </summary>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void OpenSSL_add_all_digests();

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Ansi)]
        public extern static IntPtr SSLeay_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.0 libraries, using libssl.so.1.0.0
    /// </summary>
    internal static class InteropOpenSSL10_libssl_so_1_0_0
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl.so.1.0.0";

        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_create();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_cleanup(IntPtr ctx);

        /// <summary>
        /// Destroys (frees) the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_destroy(IntPtr ctx);

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Loads all known digest methods, should be called on initialization
        /// </summary>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void OpenSSL_add_all_digests();

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Ansi)]
        public extern static IntPtr SSLeay_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.0 libraries, using libeay32.dll
    /// </summary>
    internal static class InteropOpenSSL10_libeay32_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libeay32.dll";

        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_create();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_cleanup(IntPtr ctx);

        /// <summary>
        /// Destroys (frees) the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_destroy(IntPtr ctx);

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Loads all known digest methods, should be called on initialization
        /// </summary>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void OpenSSL_add_all_digests();

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true, CharSet = CharSet.Ansi)]
        public extern static IntPtr SSLeay_version(int t = 0);
    }



    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libssl
    /// </summary>
    internal static class InteropOpenSSL11_libssl
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libssl.so.1.1
    /// </summary>
    internal static class InteropOpenSSL11_libssl_so_1_1
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl.so.1.1";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libssl.so.1.1.0
    /// </summary>
    internal static class InteropOpenSSL11_libssl_so_1_1_0
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl.so.1.1.0";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libcrypto.dll
    /// </summary>
    internal static class InteropOpenSSL11_libcrypto_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libcrypto-1_1.dll
    /// </summary>
    internal static class InteropOpenSSL11_libcrypto_1_1_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto-1_1.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libcrypto-1_1-x64.dll
    /// </summary>
    internal static class InteropOpenSSL11_libcrypto_1_1_x64_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto-1_1-x64.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}

    /// <summary>
    /// P/Invoke signatures for OpenSSL 1.1 libraries, using libcrypto-x64.dll
    /// </summary>
    internal static class InteropOpenSSL11_libcrypto_x64_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto-x64.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);
		[DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_get_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);    
		
		/// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const long with the SSL version.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int OpenSSL_version_num();
		}


    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libssl
    /// </summary>
    internal static class InteropOpenSSL3_libssl
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libssl.so.3
    /// </summary>
    internal static class InteropOpenSSL3_libssl_so_3
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libssl.so.3";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libcrypto.so
    /// </summary>
    internal static class InteropOpenSSL3_libcrypto_so
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto.so";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libcrypto.so.3
    /// </summary>
    internal static class InteropOpenSSL3_libcrypto_so_3
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto.so.3";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libcrypto-3.dll
    /// </summary>
    internal static class InteropOpenSSL3_libcrypto_3_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto-3.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

    /// <summary>
    /// P/Invoke signatures for OpenSSL 3 libraries, using libcrypto-3-x64.dll
    /// </summary>
    internal static class InteropOpenSSL3_libcrypto_3_x64_dll
    {
        /// <summary>
        /// The library implementing OpenSSL (automatically uses .dll, .so, or .dylib)
        /// </summary>
        private const string DLLNAME = "libcrypto-3-x64.dll";

        /// <summary>
        /// Initializes the message digest context with the hashing method
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="type">The digest type.</param>
        /// <param name="impl">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestInit_ex(IntPtr ctx, IntPtr type, IntPtr impl);

        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, byte[] data, uint cnt);
        
        /// <summary>
        /// Processes a chunk of data, updating the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The message digest context.</param>
        /// <param name="data">The data to update the digest with.</param>
        /// <param name="cnt">The number of bytes in the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestUpdate(IntPtr ctx, IntPtr data, uint cnt);

        /// <summary>
        /// Completes the message digest
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">The context to use.</param>
        /// <param name="result">A buffer to contain the result.</param>
        /// <param name="s">The length of the buffer.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_DigestFinal_ex(IntPtr ctx, byte[] result, ref uint s);

        /// <summary>
        /// Gets the digest implementation from a anme
        /// </summary>
        /// <returns>The digest implementation or null.</returns>
        /// <param name="name">The name of the digets to find.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_get_digestbyname(string name);


        /// <summary>
        /// Creates the message digest context
        /// </summary>
        /// <returns>The message digest context.</returns>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr EVP_MD_CTX_new();

        /// <summary>
        /// Resets the message digest context
        /// </summary>
        /// <returns>1 for succes or 0 for failure.</returns>
        /// <param name="ctx">Context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_CTX_reset(IntPtr ctx);

        /// <summary>
        /// Frees the message digest context
        /// </summary>
        /// <param name="ctx">The message digest context.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static void EVP_MD_CTX_free(IntPtr ctx);

        /// <summary>
        /// Gets the size of the message digest result
        /// </summary>
        /// <returns>The message digest size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, EntryPoint = "EVP_MD_get_size", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_size(IntPtr md);

        /// <summary>
        /// Gets the size of the input blocks
        /// </summary>
        /// <returns>The input block size.</returns>
        /// <param name="md">The digest implementation.</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static int EVP_MD_block_size(IntPtr md);

        /// <summary>
        /// Gets the string representation of the SSL library version
        /// </summary>
        /// <returns>A const char* with the SSL version.</returns>
        /// <param name="t">The version information to obtain (use zero).</param>
        [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public extern static IntPtr OpenSSL_version(int t = 0);
    }

}