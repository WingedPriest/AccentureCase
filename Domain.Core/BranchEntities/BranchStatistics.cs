using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core.BranchEntities
{
    public class BranchStatistics
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        public int BranchId { get; set; }//Номер филиала
        public decimal BalancesheetCurrency { get; set; }//Баланс ввалюты
        public decimal BalanceSheetProfit { get; set; }//Балансовая прибыль
        public decimal LoansLegalEntities { get; set; }//Кредиты юридическим лицам
        public decimal LoansIndividuals { get; set; }//Кредиты физическим лицам
        public decimal FundsLegalEntities { get; set; }//Средства юридических лиц
        public decimal FundsIndividuals { get; set; }//Средства физических лиц
        public decimal DebtObligationsIssued { get; set; }//Выпущенные долговые обязательства
        public decimal NumberEmployees { get; set; }//Численность сотрудников
        public string ReportDate { get; set; }//Дата


    }
}
