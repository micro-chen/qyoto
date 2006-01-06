//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QLocale")]
	public class QLocale : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QLocale(Type dummy) {}
		interface IQLocaleProxy {
			string LanguageToString(int language);
			string CountryToString(int country);
			void SetDefault(QLocale locale);
			QLocale C();
			QLocale System();
		}

		protected void CreateQLocaleProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLocale), this);
			_interceptor = (QLocale) realProxy.GetTransparentProxy();
		}
		private QLocale ProxyQLocale() {
			return (QLocale) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLocale() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLocaleProxy), null);
			_staticInterceptor = (IQLocaleProxy) realProxy.GetTransparentProxy();
		}
		private static IQLocaleProxy StaticQLocale() {
			return (IQLocaleProxy) _staticInterceptor;
		}

		enum E_Language {
			C = 1,
			Abkhazian = 2,
			Afan = 3,
			Afar = 4,
			Afrikaans = 5,
			Albanian = 6,
			Amharic = 7,
			Arabic = 8,
			Armenian = 9,
			Assamese = 10,
			Aymara = 11,
			Azerbaijani = 12,
			Bashkir = 13,
			Basque = 14,
			Bengali = 15,
			Bhutani = 16,
			Bihari = 17,
			Bislama = 18,
			Breton = 19,
			Bulgarian = 20,
			Burmese = 21,
			Byelorussian = 22,
			Cambodian = 23,
			Catalan = 24,
			Chinese = 25,
			Corsican = 26,
			Croatian = 27,
			Czech = 28,
			Danish = 29,
			Dutch = 30,
			English = 31,
			Esperanto = 32,
			Estonian = 33,
			Faroese = 34,
			FijiLanguage = 35,
			Finnish = 36,
			French = 37,
			Frisian = 38,
			Gaelic = 39,
			Galician = 40,
			Georgian = 41,
			German = 42,
			Greek = 43,
			Greenlandic = 44,
			Guarani = 45,
			Gujarati = 46,
			Hausa = 47,
			Hebrew = 48,
			Hindi = 49,
			Hungarian = 50,
			Icelandic = 51,
			Indonesian = 52,
			Interlingua = 53,
			Interlingue = 54,
			Inuktitut = 55,
			Inupiak = 56,
			Irish = 57,
			Italian = 58,
			Japanese = 59,
			Javanese = 60,
			Kannada = 61,
			Kashmiri = 62,
			Kazakh = 63,
			Kinyarwanda = 64,
			Kirghiz = 65,
			Korean = 66,
			Kurdish = 67,
			Kurundi = 68,
			Laothian = 69,
			Latin = 70,
			Latvian = 71,
			Lingala = 72,
			Lithuanian = 73,
			Macedonian = 74,
			Malagasy = 75,
			Malay = 76,
			Malayalam = 77,
			Maltese = 78,
			Maori = 79,
			Marathi = 80,
			Moldavian = 81,
			Mongolian = 82,
			NauruLanguage = 83,
			Nepali = 84,
			Norwegian = 85,
			Occitan = 86,
			Oriya = 87,
			Pashto = 88,
			Persian = 89,
			Polish = 90,
			Portuguese = 91,
			Punjabi = 92,
			Quechua = 93,
			RhaetoRomance = 94,
			Romanian = 95,
			Russian = 96,
			Samoan = 97,
			Sangho = 98,
			Sanskrit = 99,
			Serbian = 100,
			SerboCroatian = 101,
			Sesotho = 102,
			Setswana = 103,
			Shona = 104,
			Sindhi = 105,
			Singhalese = 106,
			Siswati = 107,
			Slovak = 108,
			Slovenian = 109,
			Somali = 110,
			Spanish = 111,
			Sundanese = 112,
			Swahili = 113,
			Swedish = 114,
			Tagalog = 115,
			Tajik = 116,
			Tamil = 117,
			Tatar = 118,
			Telugu = 119,
			Thai = 120,
			Tibetan = 121,
			Tigrinya = 122,
			TongaLanguage = 123,
			Tsonga = 124,
			Turkish = 125,
			Turkmen = 126,
			Twi = 127,
			Uigur = 128,
			Ukrainian = 129,
			Urdu = 130,
			Uzbek = 131,
			Vietnamese = 132,
			Volapuk = 133,
			Welsh = 134,
			Wolof = 135,
			Xhosa = 136,
			Yiddish = 137,
			Yoruba = 138,
			Zhuang = 139,
			Zulu = 140,
			LastLanguage = Zulu,
		}
		enum E_Country {
			AnyCountry = 0,
			Afghanistan = 1,
			Albania = 2,
			Algeria = 3,
			AmericanSamoa = 4,
			Andorra = 5,
			Angola = 6,
			Anguilla = 7,
			Antarctica = 8,
			AntiguaAndBarbuda = 9,
			Argentina = 10,
			Armenia = 11,
			Aruba = 12,
			Australia = 13,
			Austria = 14,
			Azerbaijan = 15,
			Bahamas = 16,
			Bahrain = 17,
			Bangladesh = 18,
			Barbados = 19,
			Belarus = 20,
			Belgium = 21,
			Belize = 22,
			Benin = 23,
			Bermuda = 24,
			Bhutan = 25,
			Bolivia = 26,
			BosniaAndHerzegowina = 27,
			Botswana = 28,
			BouvetIsland = 29,
			Brazil = 30,
			BritishIndianOceanTerritory = 31,
			BruneiDarussalam = 32,
			Bulgaria = 33,
			BurkinaFaso = 34,
			Burundi = 35,
			Cambodia = 36,
			Cameroon = 37,
			Canada = 38,
			CapeVerde = 39,
			CaymanIslands = 40,
			CentralAfricanRepublic = 41,
			Chad = 42,
			Chile = 43,
			China = 44,
			ChristmasIsland = 45,
			CocosIslands = 46,
			Colombia = 47,
			Comoros = 48,
			DemocraticRepublicOfCongo = 49,
			PeoplesRepublicOfCongo = 50,
			CookIslands = 51,
			CostaRica = 52,
			IvoryCoast = 53,
			Croatia = 54,
			Cuba = 55,
			Cyprus = 56,
			CzechRepublic = 57,
			Denmark = 58,
			Djibouti = 59,
			Dominica = 60,
			DominicanRepublic = 61,
			EastTimor = 62,
			Ecuador = 63,
			Egypt = 64,
			ElSalvador = 65,
			EquatorialGuinea = 66,
			Eritrea = 67,
			Estonia = 68,
			Ethiopia = 69,
			FalklandIslands = 70,
			FaroeIslands = 71,
			FijiCountry = 72,
			Finland = 73,
			France = 74,
			MetropolitanFrance = 75,
			FrenchGuiana = 76,
			FrenchPolynesia = 77,
			FrenchSouthernTerritories = 78,
			Gabon = 79,
			Gambia = 80,
			Georgia = 81,
			Germany = 82,
			Ghana = 83,
			Gibraltar = 84,
			Greece = 85,
			Greenland = 86,
			Grenada = 87,
			Guadeloupe = 88,
			Guam = 89,
			Guatemala = 90,
			Guinea = 91,
			GuineaBissau = 92,
			Guyana = 93,
			Haiti = 94,
			HeardAndMcDonaldIslands = 95,
			Honduras = 96,
			HongKong = 97,
			Hungary = 98,
			Iceland = 99,
			India = 100,
			Indonesia = 101,
			Iran = 102,
			Iraq = 103,
			Ireland = 104,
			Israel = 105,
			Italy = 106,
			Jamaica = 107,
			Japan = 108,
			Jordan = 109,
			Kazakhstan = 110,
			Kenya = 111,
			Kiribati = 112,
			DemocraticRepublicOfKorea = 113,
			RepublicOfKorea = 114,
			Kuwait = 115,
			Kyrgyzstan = 116,
			Lao = 117,
			Latvia = 118,
			Lebanon = 119,
			Lesotho = 120,
			Liberia = 121,
			LibyanArabJamahiriya = 122,
			Liechtenstein = 123,
			Lithuania = 124,
			Luxembourg = 125,
			Macau = 126,
			Macedonia = 127,
			Madagascar = 128,
			Malawi = 129,
			Malaysia = 130,
			Maldives = 131,
			Mali = 132,
			Malta = 133,
			MarshallIslands = 134,
			Martinique = 135,
			Mauritania = 136,
			Mauritius = 137,
			Mayotte = 138,
			Mexico = 139,
			Micronesia = 140,
			Moldova = 141,
			Monaco = 142,
			Mongolia = 143,
			Montserrat = 144,
			Morocco = 145,
			Mozambique = 146,
			Myanmar = 147,
			Namibia = 148,
			NauruCountry = 149,
			Nepal = 150,
			Netherlands = 151,
			NetherlandsAntilles = 152,
			NewCaledonia = 153,
			NewZealand = 154,
			Nicaragua = 155,
			Niger = 156,
			Nigeria = 157,
			Niue = 158,
			NorfolkIsland = 159,
			NorthernMarianaIslands = 160,
			Norway = 161,
			Oman = 162,
			Pakistan = 163,
			Palau = 164,
			PalestinianTerritory = 165,
			Panama = 166,
			PapuaNewGuinea = 167,
			Paraguay = 168,
			Peru = 169,
			Philippines = 170,
			Pitcairn = 171,
			Poland = 172,
			Portugal = 173,
			PuertoRico = 174,
			Qatar = 175,
			Reunion = 176,
			Romania = 177,
			RussianFederation = 178,
			Rwanda = 179,
			SaintKittsAndNevis = 180,
			StLucia = 181,
			StVincentAndTheGrenadines = 182,
			Samoa = 183,
			SanMarino = 184,
			SaoTomeAndPrincipe = 185,
			SaudiArabia = 186,
			Senegal = 187,
			Seychelles = 188,
			SierraLeone = 189,
			Singapore = 190,
			Slovakia = 191,
			Slovenia = 192,
			SolomonIslands = 193,
			Somalia = 194,
			SouthAfrica = 195,
			SouthGeorgiaAndTheSouthSandwichIslands = 196,
			Spain = 197,
			SriLanka = 198,
			StHelena = 199,
			StPierreAndMiquelon = 200,
			Sudan = 201,
			Suriname = 202,
			SvalbardAndJanMayenIslands = 203,
			Swaziland = 204,
			Sweden = 205,
			Switzerland = 206,
			SyrianArabRepublic = 207,
			Taiwan = 208,
			Tajikistan = 209,
			Tanzania = 210,
			Thailand = 211,
			Togo = 212,
			Tokelau = 213,
			TongaCountry = 214,
			TrinidadAndTobago = 215,
			Tunisia = 216,
			Turkey = 217,
			Turkmenistan = 218,
			TurksAndCaicosIslands = 219,
			Tuvalu = 220,
			Uganda = 221,
			Ukraine = 222,
			UnitedArabEmirates = 223,
			UnitedKingdom = 224,
			UnitedStates = 225,
			UnitedStatesMinorOutlyingIslands = 226,
			Uruguay = 227,
			Uzbekistan = 228,
			Vanuatu = 229,
			VaticanCityState = 230,
			Venezuela = 231,
			VietNam = 232,
			BritishVirginIslands = 233,
			USVirginIslands = 234,
			WallisAndFutunaIslands = 235,
			WesternSahara = 236,
			Yemen = 237,
			Yugoslavia = 238,
			Zambia = 239,
			Zimbabwe = 240,
			LastCountry = Zimbabwe,
		}
		public QLocale() : this((Type) null) {
			CreateQLocaleProxy();
			NewQLocale();
		}
		[SmokeMethod("QLocale()")]
		private void NewQLocale() {
			ProxyQLocale().NewQLocale();
		}
		public QLocale(string name) : this((Type) null) {
			CreateQLocaleProxy();
			NewQLocale(name);
		}
		[SmokeMethod("QLocale(const QString&)")]
		private void NewQLocale(string name) {
			ProxyQLocale().NewQLocale(name);
		}
		public QLocale(int language, int country) : this((Type) null) {
			CreateQLocaleProxy();
			NewQLocale(language,country);
		}
		[SmokeMethod("QLocale(QLocale::Language, QLocale::Country)")]
		private void NewQLocale(int language, int country) {
			ProxyQLocale().NewQLocale(language,country);
		}
		public QLocale(int language) : this((Type) null) {
			CreateQLocaleProxy();
			NewQLocale(language);
		}
		[SmokeMethod("QLocale(QLocale::Language)")]
		private void NewQLocale(int language) {
			ProxyQLocale().NewQLocale(language);
		}
		public QLocale(QLocale other) : this((Type) null) {
			CreateQLocaleProxy();
			NewQLocale(other);
		}
		[SmokeMethod("QLocale(const QLocale&)")]
		private void NewQLocale(QLocale other) {
			ProxyQLocale().NewQLocale(other);
		}
		[SmokeMethod("language() const")]
		public int Language() {
			return ProxyQLocale().Language();
		}
		[SmokeMethod("country() const")]
		public int Country() {
			return ProxyQLocale().Country();
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQLocale().Name();
		}
		[SmokeMethod("toShort(const QString&, bool*) const")]
		public short ToShort(string s, out bool ok) {
			return ProxyQLocale().ToShort(s,out ok);
		}
		[SmokeMethod("toShort(const QString&) const")]
		public short ToShort(string s) {
			return ProxyQLocale().ToShort(s);
		}
		[SmokeMethod("toUShort(const QString&, bool*) const")]
		public ushort ToUShort(string s, out bool ok) {
			return ProxyQLocale().ToUShort(s,out ok);
		}
		[SmokeMethod("toUShort(const QString&) const")]
		public ushort ToUShort(string s) {
			return ProxyQLocale().ToUShort(s);
		}
		[SmokeMethod("toInt(const QString&, bool*) const")]
		public int ToInt(string s, out bool ok) {
			return ProxyQLocale().ToInt(s,out ok);
		}
		[SmokeMethod("toInt(const QString&) const")]
		public int ToInt(string s) {
			return ProxyQLocale().ToInt(s);
		}
		[SmokeMethod("toUInt(const QString&, bool*) const")]
		public uint ToUInt(string s, out bool ok) {
			return ProxyQLocale().ToUInt(s,out ok);
		}
		[SmokeMethod("toUInt(const QString&) const")]
		public uint ToUInt(string s) {
			return ProxyQLocale().ToUInt(s);
		}
		[SmokeMethod("toLong(const QString&, bool*) const")]
		public long ToLong(string s, out bool ok) {
			return ProxyQLocale().ToLong(s,out ok);
		}
		[SmokeMethod("toLong(const QString&) const")]
		public long ToLong(string s) {
			return ProxyQLocale().ToLong(s);
		}
		[SmokeMethod("toULong(const QString&, bool*) const")]
		public long ToULong(string s, out bool ok) {
			return ProxyQLocale().ToULong(s,out ok);
		}
		[SmokeMethod("toULong(const QString&) const")]
		public long ToULong(string s) {
			return ProxyQLocale().ToULong(s);
		}
		// Q_LLONG toLongLong(const QString& arg1,bool* arg2); >>>> NOT CONVERTED
		// Q_LLONG toLongLong(const QString& arg1); >>>> NOT CONVERTED
		// Q_ULLONG toULongLong(const QString& arg1,bool* arg2); >>>> NOT CONVERTED
		// Q_ULLONG toULongLong(const QString& arg1); >>>> NOT CONVERTED
		[SmokeMethod("toFloat(const QString&, bool*) const")]
		public float ToFloat(string s, out bool ok) {
			return ProxyQLocale().ToFloat(s,out ok);
		}
		[SmokeMethod("toFloat(const QString&) const")]
		public float ToFloat(string s) {
			return ProxyQLocale().ToFloat(s);
		}
		[SmokeMethod("toDouble(const QString&, bool*) const")]
		public double ToDouble(string s, out bool ok) {
			return ProxyQLocale().ToDouble(s,out ok);
		}
		[SmokeMethod("toDouble(const QString&) const")]
		public double ToDouble(string s) {
			return ProxyQLocale().ToDouble(s);
		}
		[SmokeMethod("toString(short) const")]
		public new string ToString(short i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("toString(ushort) const")]
		public new string ToString(ushort i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("toString(int) const")]
		public new string ToString(int i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("toString(uint) const")]
		public new string ToString(uint i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("toString(Q_LONG) const")]
		public new string ToString(long i) {
			return ProxyQLocale().ToString(i);
		}
		// QString toString(Q_LLONG arg1); >>>> NOT CONVERTED
		// QString toString(Q_ULLONG arg1); >>>> NOT CONVERTED
		[SmokeMethod("toString(float, char, int) const")]
		public new string ToString(float i, char f, int prec) {
			return ProxyQLocale().ToString(i,f,prec);
		}
		[SmokeMethod("toString(float, char) const")]
		public new string ToString(float i, char f) {
			return ProxyQLocale().ToString(i,f);
		}
		[SmokeMethod("toString(float) const")]
		public new string ToString(float i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("toString(double, char, int) const")]
		public new string ToString(double i, char f, int prec) {
			return ProxyQLocale().ToString(i,f,prec);
		}
		[SmokeMethod("toString(double, char) const")]
		public new string ToString(double i, char f) {
			return ProxyQLocale().ToString(i,f);
		}
		[SmokeMethod("toString(double) const")]
		public new string ToString(double i) {
			return ProxyQLocale().ToString(i);
		}
		[SmokeMethod("languageToString(QLocale::Language)")]
		public static string LanguageToString(int language) {
			return StaticQLocale().LanguageToString(language);
		}
		[SmokeMethod("countryToString(QLocale::Country)")]
		public static string CountryToString(int country) {
			return StaticQLocale().CountryToString(country);
		}
		[SmokeMethod("setDefault(const QLocale&)")]
		public static void SetDefault(QLocale locale) {
			StaticQLocale().SetDefault(locale);
		}
		[SmokeMethod("c()")]
		public static QLocale C() {
			return StaticQLocale().C();
		}
		[SmokeMethod("system()")]
		public static QLocale System() {
			return StaticQLocale().System();
		}
		~QLocale() {
			DisposeQLocale();
		}
		public void Dispose() {
			DisposeQLocale();
		}
		private void DisposeQLocale() {
			ProxyQLocale().DisposeQLocale();
		}
	}
}
