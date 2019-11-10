using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _3342_TermProject_API.Classes;

namespace _3342_TermProject_API.Controllers
{
    [Produces("application/json")]
    [Route("api/service/PaymentGateway")]
    [ApiController]
    public class MerchantTransactionController : ControllerBase
    {
        [HttpPost]
        public Wallet CreateVirtualWallet(Wallet AccountHolderInformation, Wallet MerchantAccountID, Wallet APIKey)
        {
            Wallet wallet = new Wallet();
            return wallet ;
        }
        // GET: api/MerchantTransaction
        [HttpGet]
        public List<Wallet> GetTransactions()
        {
            List<Wallet> wallets = new List<Wallet>();
            return wallets;
        }
        [HttpPost]
        public Wallet ProcessPayment(Wallet VirtualWalletID, Transaction Amount, Transaction type, Merchant MerchantAccountID, Wallet APIKey )
        {
            Wallet wallet = new Wallet();
            return wallet;
        }
        [HttpPut]
        public Transaction UpdatePaymentAccount()
        {
            Transaction transaction = new Transaction();
            return transaction;
        }
        [HttpPut]
        public Transaction FundAccount(Wallet VirtualWalletID, Transaction Amount, Merchant MerchantAccountID, Wallet APIKey)
        {
            Transaction transaction = new Transaction();
            return transaction;
        }     
    }
}
