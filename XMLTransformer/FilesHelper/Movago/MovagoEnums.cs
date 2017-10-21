using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class MovagoEnums
    {
        public enum MovagoTipiRecordDettaglio : int
        {
            PRIMA_PARTE_CLIENTI_FORNITORI = 10,
            SECONDA_PARTE_CLIENTI_FORNITORI = 11,
            TESTATA_FATTURA = 30,
            RIGA_FATTURA = 31,
            CORRISPETTIVI = 40,
            MOVIMENTO_PRIMA_NOTA_TESTATA = 50,
            MOVIMENTO_INCASSO_PAGAMENTO = 60
        }

        public enum MovagoClienteFornitore : int
        {
            CLIENTE = 1,
            FORNITORE = 2
        }

        public enum MovimTipoFattura : int
        {
            NORMALE = 1,
            FISCALE = 2,
            SCONTRINO = 3
        }

        public enum TipoPagamento : int
        {
            IMMEDIATO = 0,
            NON_IMMEDIATO = 1
        }

        public enum GenerazionePartita : int
        {
            PARTITA_APERTA = 0,
            PARTITA_NON_APERTA = 1
        }

        public enum OpposizioneAssistito : int
        {
            TESSERA_SANITARIA = 0,
            NO_TESSERA_SANITARIA = 1
        }

        public enum TipoIVA : int
        {
            IVA_1 = 1,
            IVA_2 = 2,
            IVA_3 = 3,
            IVA_4 = 4,
            IVA_5 = 5,
            IVA_6 = 6,
            IVA_7 = 7,
            IVA_8 = 8
        }

        public enum TipoFattureRateAperte : int
        {
            FATTURE_DA_INCASSARE = 103,
            FATTURE_DA_PAGARE = 104
        }
    }
}
