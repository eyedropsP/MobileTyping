using System.Collections.Generic;

namespace MobileTyping.Scripts
{
    public static class KeyMapConstants
    {
        internal static readonly Dictionary<string, string[]> KeyMap = new Dictionary<string, string[]>
        {
            {"あ", new[] {"a"}}, {"い", new[] {"i", "yi"}}, {"う", new[] {"u", "wu", "whu"}},
            {"え", new[] {"e"}}, {"お", new[] {"o"}},
            {"か", new[] {"ka", "ca"}}, {"き", new[] {"ki"}}, {"く", new[] {"ku", "cu", "qu"}},
            {"け", new[] {"ke"}}, {"こ", new[] {"ko", "co"}},
            {"さ", new[] {"sa"}}, {"し", new[] {"si", "shi", "ci"}}, {"す", new[] {"su"}},
            {"せ", new[] {"se", "ce"}}, {"そ", new[] {"so"}},
            {"た", new[] {"ta"}}, {"ち", new[] {"ti", "chi"}}, {"つ", new[] {"tu", "tsu"}},
            {"て", new[] {"te"}}, {"と", new[] {"to"}},
            {"な", new[] {"na"}}, {"に", new[] {"ni"}}, {"ぬ", new[] {"nu"}},
            {"ね", new[] {"ne"}}, {"の", new[] {"no"}},
            {"は", new[] {"ha"}}, {"ひ", new[] {"hi"}}, {"ふ", new[] {"fu", "hu"}},
            {"へ", new[] {"he"}}, {"ほ", new[] {"ho"}},
            {"ま", new[] {"ma"}}, {"み", new[] {"mi"}}, {"む", new[] {"mu"}},
            {"め", new[] {"me"}}, {"も", new[] {"mo"}},
            {"や", new[] {"ya"}}, {"ゆ", new[] {"yu"}}, {"よ", new[] {"yo"}},
            {"ら", new[] {"ra"}}, {"り", new[] {"ri"}}, {"る", new[] {"ru"}},
            {"れ", new[] {"re"}}, {"ろ", new[] {"ro"}},
            {"わ", new[] {"wa"}}, {"を", new[] {"wo"}}, {"ん", new[] {"n", "nn", "xn"}},
            {"が", new[] {"ga"}}, {"ぎ", new[] {"gi"}}, {"ぐ", new[] {"gu"}},
            {"げ", new[] {"ge"}}, {"ご", new[] {"go"}},
            {"ざ", new[] {"za"}}, {"じ", new[] {"ji", "zi"}}, {"ず", new[] {"zu"}},
            {"ぜ", new[] {"ze"}}, {"ぞ", new[] {"zo"}},
            {"だ", new[] {"da"}}, {"ぢ", new[] {"di"}}, {"づ", new[] {"du"}},
            {"で", new[] {"de"}}, {"ど", new[] {"do"}}, {"ば", new[] {"ba"}},
            {"び", new[] {"bi"}}, {"ぶ", new[] {"bu"}}, {"べ", new[] {"be"}},
            {"ぼ", new[] {"bo"}},
            {"ぱ", new[] {"pa"}}, {"ぴ", new[] {"pi"}}, {"ぷ", new[] {"pu"}},
            {"ぺ", new[] {"pe"}}, {"ぽ", new[] {"po"}},
            {"ぁ", new[] {"la", "xa"}}, {"ぃ", new[] {"li", "xi", "lyi", "xyi"}},
            {"ぅ", new[] {"lu", "xu"}}, {"ぇ", new[] {"le", "xe", "lye", "xye"}},
            {"ぉ", new[] {"lo", "xo"}},
            {"ゃ", new[] {"lya", "xya"}}, {"ゅ", new[] {"lyu", "xyu"}},
            {"ょ", new[] {"lyo", "xyo"}},
            {"っ", new[] {"ltu", "ltsu", "xtu", "xtsu"}},
            {"きゃ", new[] {"kya", "kilya", "kixya"}},
            {"きぃ", new[] {"kyi", "kili", "kilyi", "kixi", "kixyi"}},
            {"きゅ", new[] {"kyu", "kilyu", "kixyu"}},
            {"きぇ", new[] {"kye", "kile", "kilye", "kixe", "kixye"}},
            {"きょ", new[] {"kyo", "kilyo", "kixyo"}},
            {"ぎゃ", new[] {"gya", "gilya", "gixya"}},
            {"ぎぃ", new[] {"gyi", "gili", "gilyi", "gixi", "gixyi"}},
            {"ぎゅ", new[] {"gyu", "gilyu", "gixyu"}},
            {"ぎぇ", new[] {"gye", "gile", "gilye", "gixe", "gixye"}},
            {"ぎょ", new[] {"gyo", "gilyo", "gixyo"}},
            {"くぁ", new[] {"qa", "kwa", "kula", "kuxa", "cula", "cuxa", "qula", "quxa"}},
            {
                "くぃ",
                new[]
                {
                    "qi", "qyi", "kuli", "kuxi", "kulyi", "kuxyi", "culi", "culyi", "cuxi", "cuxyi", "quli", "quxi",
                    "qulyi", "quxyi"
                }
            },
            {"くぅ", new[] {"qwu", "kulu", "kuxu", "culu", "cuxu", "qulu", "quxu"}},
            {
                "くぇ",
                new[]
                {
                    "qe", "qwe", "kule", "kuxe", "kulye", "kuxye", "cule", "cuxe", "culye", "cuxye", "qule", "quxe",
                    "qulye", "quxye"
                }
            },
            {"くぉ", new[] {"qo", "qwo", "kulo", "kuxo", "culo", "cuxo", "qulo", "quxo"}},
            {"ぐぁ", new[] {"gwa", "gula", "guxa"}},
            {"ぐぃ", new[] {"gwi", "guli", "gulyi", "guxi", "guxyi"}},
            {"ぐぅ", new[] {"gwu", "gulu", "guxu"}},
            {"ぐぇ", new[] {"gwe", "gule", "guxe", "gulye", "guxye"}},
            {"ぐぉ", new[] {"gwo", "gulo", "guxo"}},
            {"しゃ", new[] {"sya", "sha", "silya", "sixya", "shilya", "shixya", "cilya", "cixya"}},
            {
                "しぃ",
                new[]
                {
                    "syi", "sili", "sixi", "silyi", "sixyi", "shili", "shixi", "shilyi", "shixyi", "cili", "cixi",
                    "cilyi", "cixyi"
                }
            },
            {"しゅ", new[] {"syu", "shu", "silyu", "sixyu", "shilyu", "shixyu", "cilyu", "cixyu"}},
            {
                "しぇ",
                new[]
                {
                    "sye", "she", "sile", "silye", "sixe", "sixye", "shile", "shilye", "shixe", "shixye", "cile",
                    "cilye", "cixe", "cixye"
                }
            },
            {"しょ", new[] {"syo", "sho", "silyo", "sixyo", "shilyo", "shixyo", "cilyo", "cixyo"}},
            {"じゃ", new[] {"ja", "jya", "zya", "jilya", "jixya", "zilya", "zixya"}},
            {"じぃ", new[] {"jyi", "zyi", "jili", "jixi", "jilyi", "jixyi", "zili", "zixi", "zilyi", "zixyi"}},
            {"じゅ", new[] {"ju", "jyu", "zyu", "jilyu", "jixyu", "zilyu", "zixyu"}},
            {
                "じぇ",
                new[] {"je", "jye", "zye", "jile", "jixe", "jilye", "jixye", "zile", "zixe", "zilye", "zixye"}
            },
            {"じょ", new[] {"jo", "jyo", "zyo", "jilyo", "jixyo", "zilyo", "zixyo"}},
            {"すぁ", new[] {"swa", "sula", "suxa"}},
            {"すぃ", new[] {"swi", "suli", "sulyi", "suxi", "suxyi"}},
            {"すぅ", new[] {"swu", "sulu", "suxu"}},
            {"すぇ", new[] {"swe", "sule", "suxe", "sulye", "suxye"}},
            {"すぉ", new[] {"swo", "sulo", "suxo"}},
            {"ちゃ", new[] {"tya", "cha", "cya", "tilya", "tixya", "chilya", "chixya"}},
            {
                "ちぃ",
                new[] {"tyi", "cyi", "tili", "tixi", "tilyi", "tixyi", "chili", "chixi", "chilyi", "chixyi"}
            },
            {"ちゅ", new[] {"tyu", "chu", "cyu", "tilyu", "tixyu", "chilyu", "chixyu"}},
            {
                "ちぇ",
                new[]
                    {"tye", "che", "cye", "tile", "tixe", "tilye", "tixye", "chile", "chixe", "chilye", "chixye"}
            },
            {"ちょ", new[] {"tyo", "cho", "cyo", "tilyo", "tixyo", "chilyo", "chixyo"}},
            {"ぢゃ", new[] {"dya", "dilya", "dixya"}},
            {"ぢゅ", new[] {"dyu", "dilyu", "dixyu"}},
            {"ぢぇ", new[] {"dye", "dile", "dixe", "dilye", "dixye"}},
            {"ぢょ", new[] {"dyo", "dilyo", "dixyo"}},
            {"つぁ", new[] {"tsa", "tula", "tuxa", "tsula", "tsuxa"}},
            {"つぃ", new[] {"tsi", "tuli", "tuxi", "tulyi", "tuxyi", "tsuli", "tsuxi", "tsulyi", "tsuxyi"}},
            {"つぇ", new[] {"tse", "tule", "tuxe", "tulye", "tuxye", "tsule", "tsuxe", "tsulye", "tsuxye"}},
            {"つぉ", new[] {"tso", "tulo", "tuxo", "tsulo", "tsuxo"}},
            {"てゃ", new[] {"tha", "telya", "texya"}},
            {"てぃ", new[] {"thi", "teli", "texi", "telyi", "texyi"}},
            {"てゅ", new[] {"thu", "telyu", "texyu"}},
            {"てぇ", new[] {"the", "tele", "texe", "telye", "texye"}},
            {"てょ", new[] {"tho", "telyo", "texyo"}},
            {"でゃ", new[] {"dha", "delya", "dexya"}},
            {"でぃ", new[] {"dhi", "deli", "dexi", "delyi", "dexyi"}},
            {"でゅ", new[] {"dhu", "delyu", "dexyu"}},
            {"でぇ", new[] {"dhe", "dele", "dexe", "delye", "dexye"}},
            {"でょ", new[] {"dho", "delyo", "dexyo"}},
            {"とぁ", new[] {"twa", "tola", "toxa"}},
            {"とぃ", new[] {"twi", "toli", "toxi", "tolyi", "toxyi"}},
            {"とぅ", new[] {"twu", "tolu", "toxu"}},
            {"とぇ", new[] {"twe", "tole", "toxe", "tolye", "toxye"}},
            {"とぉ", new[] {"two", "tolo", "toxo"}},
            {"どぁ", new[] {"dwa", "dola", "doxa"}},
            {"どぃ", new[] {"dwi", "doli", "doxi", "dolyi", "doxyi"}},
            {"どぅ", new[] {"dwu", "dolu", "doxu"}},
            {"どぇ", new[] {"dwe", "dole", "doxe", "dolye", "doxye"}},
            {"どぉ", new[] {"dwo", "dolo", "doxo"}},
            {"にゃ", new[] {"nya", "nilya", "nixya"}},
            {"にぃ", new[] {"nyi", "nili", "nixi", "nilyi", "nixyi"}},
            {"にゅ", new[] {"nyu", "nilyu", "nixyu"}},
            {"にぇ", new[] {"nye", "nile", "nixe", "nilye", "nixye"}},
            {"にょ", new[] {"nyo", "nilyo", "nixyo"}},
            {"ぴゃ", new[] {"pya", "pilya", "pixya"}},
            {"ぴぃ", new[] {"pyi", "pili", "pixi", "pilyi", "pixyi"}},
            {"ぴゅ", new[] {"pyu", "pilyu", "pixyu"}},
            {"ぴぇ", new[] {"pye", "pile", "pixe", "pilye", "pixye"}},
            {"ぴょ", new[] {"pyo", "pilyo", "pixyo"}},
            {"ひゃ", new[] {"hya", "hilya", "hixya"}},
            {"ひぃ", new[] {"hyi", "hili", "hixi", "hilyi", "hixyi"}},
            {"ひゅ", new[] {"hyu", "hilyu", "hixyu"}},
            {"ひぇ", new[] {"hye", "hile", "hixe", "hilye", "hixye"}},
            {"ひょ", new[] {"hyo", "hilyo", "hixyo"}},
            {"びゃ", new[] {"bya", "bilya", "bixya"}},
            {"びぃ", new[] {"byi", "bili", "bixi", "bilyi", "bixyi"}},
            {"びゅ", new[] {"byu", "bilyu", "bixyu"}},
            {"びぇ", new[] {"bye", "bile", "bixe", "bilye", "bixye"}},
            {"びょ", new[] {"byo", "bilyo", "bixyo"}},
            {"ふゃ", new[] {"fya", "fulya", "fuxya", "hulya", "huxya"}},
            {"ふぃ", new[] {"fi", "fyi", "fuli", "fuxi", "fulyi", "fuxyi", "huli", "huxi", "hulyi", "huxyi"}},
            {"ふゅ", new[] {"fyu", "fulyu", "fuxyu", "hulyu", "huxyu"}},
            {"ふぇ", new[] {"fe", "fye", "fule", "fuxe", "fulye", "fuxye", "hule", "huxe", "hulye", "huxye"}},
            {"ふょ", new[] {"fyo", "fulyo", "fuxyo", "hulyo", "huxyo"}},
            {"ふぁ", new[] {"fa", "fula", "fuxa", "hula", "huxa"}},
            {"ふぉ", new[] {"fo", "fulo", "fuxo", "hulo", "huxo"}},
            {"みゃ", new[] {"mya", "milya", "mixya"}},
            {"みぃ", new[] {"myi", "mili", "mixi", "milyi", "mixyi"}},
            {"みゅ", new[] {"myu", "milyu", "mixyu"}},
            {"みぇ", new[] {"mye", "mile", "mixe", "milye", "mixye"}},
            {"みょ", new[] {"myo", "milyo", "mixyo"}},
            {"りゃ", new[] {"rya", "rilya", "rixya"}},
            {"りぃ", new[] {"ryi", "rili", "rixi", "rilyi", "rixyi"}},
            {"りゅ", new[] {"ryu", "rilyu", "rixyu"}},
            {"りぇ", new[] {"rye", "rile", "rixe", "rilye", "rixye"}},
            {"りょ", new[] {"ryo", "rilyo", "rixyo"}},
            {"うぁ", new[] {"wha", "ula", "uxa", "wula", "wuxa", "whula", "whuxa"}},
            {
                "うぃ",
                new[] {"wi", "whi", "uli", "uxi", "ulyi", "uxyi", "wuli", "wuxi", "wulyi", "wuxyi", "whuli"}
            },
            {
                "うぇ",
                new[]
                {
                    "we", "whe", "ule", "uxe", "ulye", "uxye", "wule", "wuxe", "wulye", "wuxye", "whule", "whuxe",
                    "whulye", "whuxye"
                }
            },
            {"うぉ", new[] {"who", "ulo", "uxo", "wulo", "wuxo", "whulo", "whuxo"}},
            {"ゔぁ", new[] {"va", "vula", "vuxa"}},
            {"ゔぃ", new[] {"vi", "vyi", "vuli", "vuxi", "vulyi", "vuxyi"}},
            {"ゔ", new[] {"vu"}},
            {"ゔぇ", new[] {"ve", "vye", "vule", "vuxe", "vulye", "vuxye"}},
            {"ゔぉ", new[] {"vo", "vulo", "vuxo"}},
            {"ゔゃ", new[] {"vya", "vulya", "vuxya"}},
            {"ゔゅ", new[] {"vyu", "vulyu", "vuxyu"}},
            {"ゔょ", new[] {"vyo", "vulyo", "vuxyo"}},
            {"ゐ", new[] {"wyi"}},
            {"ゑ", new[] {"wye"}},
            {"んあ", new[] {"nna", "xna"}},
            {"んい", new[] {"nni", "xni", "nnyi", "xnyi"}},
            {"んう", new[] {"nnu", "xnu", "nnwu", "xnwu", "nnwhu", "xnwhu"}},
            {"んえ", new[] {"nne", "xne"}},
            {"んお", new[] {"nno", "xno"}},
            {"んか", new[] {"nka", "nca", "nnka", "nnca", "xnka", "xnca"}},
            {"んき", new[] {"nki", "nnki", "xnki"}},
            {"んく", new[] {"nku", "ncu", "nqu", "nnku", "nncu", "nnqu", "xnku", "xncu", "xnqu"}},
            {"んけ", new[] {"nke", "nnke", "xnke"}},
            {"んこ", new[] {"nko", "nco", "nnko", "nnco", "xnko", "xnco"}},
            {"んさ", new[] {"nsa", "nnsa", "xnsa"}},
            {"んし", new[] {"nsi", "nshi", "nci", "nnsi", "nnshi", "nnci", "xnsi", "xnshi", "xnci"}},
            {"んす", new[] {"nsu", "nnsu", "xnsu"}},
            {"んせ", new[] {"nse", "nce", "nnse", "nnce", "xnse", "xnce"}},
            {"んそ", new[] {"nso", "nnso", "xnso"}},
            {"んた", new[] {"nta", "nnta", "xnta"}},
            {"んち", new[] {"nti", "nchi", "nnti", "nnchi", "xnti", "xnchi"}},
            {"んつ", new[] {"ntu", "ntsu", "nntu", "nntsu", "xntu", "xntsu"}},
            {"んて", new[] {"nte", "nnte", "xnte"}},
            {"んと", new[] {"nto", "nnto", "xnto"}},
            {"んな", new[] {"nnna", "xnna"}},
            {"んに", new[] {"nnni", "xnni"}},
            {"んぬ", new[] {"nnnu", "xnnu"}},
            {"んね", new[] {"nnne", "xnne"}},
            {"んの", new[] {"nnno", "xnno"}},
            {"んは", new[] {"nha", "nnha", "xnha"}},
            {"んひ", new[] {"nhi", "nnhi", "xnhi"}},
            {"んふ", new[] {"nfu", "nhu", "nnfu", "nnhu", "xnfu", "xnhu"}},
            {"んへ", new[] {"nhe", "nnhe", "xnhe"}},
            {"んほ", new[] {"nho", "nnho", "xnho"}},
            {"んま", new[] {"nma", "nnma", "xnma"}},
            {"んみ", new[] {"nmi", "nnmi", "xnmi"}},
            {"んむ", new[] {"nmu", "nnmu", "xnmu"}},
            {"んめ", new[] {"nme", "nnme", "xnme"}},
            {"んも", new[] {"nmo", "nnmo", "xnmo"}},
            {"んや", new[] {"nnya", "xnya"}},
            {"んゆ", new[] {"nnyu", "xnyu"}},
            {"んよ", new[] {"nnyo", "xnyo"}},
            {"んら", new[] {"nra", "nnra", "xnra"}},
            {"んり", new[] {"nri", "nnri", "xnri"}},
            {"んる", new[] {"nru", "nnru", "xnru"}},
            {"んれ", new[] {"nre", "nnre", "xnre"}},
            {"んろ", new[] {"nro", "nnro", "xnro"}},
            {"んわ", new[] {"nwa", "nnwa", "xnwa"}},
            {"んを", new[] {"nwo", "nnwo", "xnwo"}},
            {"んが", new[] {"nga", "nnga", "xnga"}},
            {"んぎ", new[] {"ngi", "nngi", "xngi"}},
            {"んぐ", new[] {"ngu", "nngu", "xngu"}},
            {"んげ", new[] {"nge", "nnge", "xnge"}},
            {"んご", new[] {"ngo", "nngo", "xngo"}},
            {"んざ", new[] {"nza", "nnza", "xnza"}},
            {"んじ", new[] {"nji", "nzi", "nnji", "nnzi", "xnji", "xnzi"}},
            {"んず", new[] {"nzu", "nnzu", "xnzu"}},
            {"んぜ", new[] {"nze", "nnze", "xnze"}},
            {"んぞ", new[] {"nzo", "nnzo", "xnze"}},
            {"んだ", new[] {"nda", "nnda", "xnda"}},
            {"んぢ", new[] {"ndi", "nndi", "xndi"}},
            {"んづ", new[] {"ndu", "nndu", "xndu"}},
            {"んで", new[] {"nde", "nnde", "xnde"}},
            {"んど", new[] {"ndo", "nndo", "xndo"}},
            {"んば", new[] {"nba", "nnba", "xnba"}},
            {"んび", new[] {"nbi", "nnbi", "xnbi"}},
            {"んぶ", new[] {"nbu", "nnbu", "xnbu"}},
            {"んべ", new[] {"nbe", "nnbe", "xnbe"}},
            {"んぼ", new[] {"nbo", "nnbo", "xnbo"}},
            {"んぱ", new[] {"npa", "nnpa", "xnpa"}},
            {"んぴ", new[] {"npi", "nnpi", "xnpi"}},
            {"んぷ", new[] {"npu", "nnpu", "xnpu"}},
            {"んぺ", new[] {"npe", "nnpe", "xnpe"}},
            {"んぽ", new[] {"npo", "nnpo", "xnpo"}},
            {
                "んきゃ",
                new[] {"nkya", "nkilya", "nkixya", "nnkya", "nnkilya", "nnkixya", "xnkya", "xnkilya", "xnkixya"}
            },
            {
                "んきぃ",
                new[]
                {
                    "nkyi", "nkili", "nkilyi", "nkixi", "nkixyi", "nnkyi", "nnkili", "nnkilyi", "nnkixi", "nnkixyi",
                    "xnkyi", "xnkili", "xnkilyi", "xnkixi", "xnkixyi"
                }
            },
            {
                "んきゅ",
                new[] {"nkyu", "nkilyu", "nkixyu", "nnkyu", "nnkilyu", "nnkixyu", "xnkyu", "xnkilyu", "xnkixyu"}
            },
            {
                "んきぇ",
                new[]
                {
                    "nkye", "nkile", "nkilye", "nkixe", "nkixye", "nnkye", "nnkile", "nnkilye", "nnkixe", "nnkixye",
                    "xnkye", "xnkile", "xnkilye", "xnkixe", "xnkixye"
                }
            },
            {
                "んきょ",
                new[] {"nkyo", "nkilyo", "nkixyo", "nnkyo", "nnkilyo", "nnkixyo", "xnkyo", "xnkilyo", "xnkixyo"}
            },
            {
                "んぎゃ",
                new[] {"ngya", "ngilya", "ngixya", "nngya", "nngilya", "nngixya", "xngya", "xngilya", "xngixya"}
            },
            {
                "んぎぃ",
                new[]
                {
                    "ngyi", "ngili", "ngilyi", "ngixi", "ngixyi", "nngyi", "nngili", "nngilyi", "nngixi", "nngixyi",
                    "xngyi", "xngili", "xngilyi", "xngixi", "xngixyi"
                }
            },
            {
                "んぎゅ",
                new[] {"ngyu", "ngilyu", "ngixyu", "nngyu", "nngilyu", "nngixyu", "xngyu", "xngilyu", "xngixyu"}
            },
            {
                "んぎぇ",
                new[]
                {
                    "ngye", "ngile", "ngilye", "ngixe", "ngixye", "nngye", "nngile", "nngilye", "nngixe", "nngixye",
                    "xngye", "xngile", "xngilye", "xngixe", "xngixye"
                }
            },
            {
                "んぎょ",
                new[] {"ngyo", "ngilyo", "ngixyo", "nngyo", "nngilyo", "nngixyo", "xngyo", "xngilyo", "xngixyo"}
            },
            {
                "んしゃ", new[]
                {
                    "nsya", "nsha", "nsilya", "nsixya", "nshilya", "nshixya", "ncilya", "ncixya",
                    "nnsya", "nnsha", "nnsilya", "nnsixya", "nnshilya", "nnshixya", "nncilya", "nncixya",
                    "xnsya", "xnsha", "xnsilya", "xnsixya", "xnshilya", "xnshixya", "xncilya", "xncixya"
                }
            },
            {
                "んしぃ", new[]
                {
                    "nsyi", "nsili", "nsixi", "nsilyi", "nsixyi", "nshili", "nshixi", "nshilyi", "nshixyi", "ncili",
                    "ncixi", "ncilyi", "ncixyi",
                    "nnsyi", "nnsili", "nnsixi", "nnsilyi", "nnsixyi", "nnshili", "nnshixi", "nnshilyi", "nnshixyi",
                    "nncili", "nncixi", "nncilyi", "nncixyi",
                    "xnsyi", "xnsili", "xnsixi", "xnsilyi", "xnsixyi", "xnshili", "xnshixi", "xnshilyi", "xnshixyi",
                    "xncili", "xncixi", "xncilyi", "xncixyi"
                }
            },
            {
                "んしゅ", new[]
                {
                    "nsyu", "nshu", "nsilyu", "nsixyu", "nshilyu", "nshixyu", "ncilyu", "ncixyu",
                    "nnsyu", "nnshu", "nnsilyu", "nnsixyu", "nnshilyu", "nnshixyu", "nncilyu", "nncixyu",
                    "xnsyu", "xnshu", "xnsilyu", "xnsixyu", "xnshilyu", "xnshixyu", "xncilyu", "xncixyu"
                }
            },
            {
                "んしぇ", new[]
                {
                    "nsye", "nshe", "nsile", "nsilye", "nsixe", "nsixye", "nshile", "nshilye", "nshixe", "nshixye",
                    "ncile", "ncilye", "ncixe", "ncixye",
                    "nnsye", "nnshe", "nnsile", "nnsilye", "nnsixe", "nnsixye", "nnshile", "nnshilye", "nnshixe",
                    "nnshixye", "nncile", "nncilye", "nncixe", "nncixye",
                    "xnsye", "xnshe", "xnsile", "xnsilye", "xnsixe", "xnsixye", "xnshile", "xnshilye", "xnshixe",
                    "xnshixye", "xncile", "xncilye", "xncixe", "xncixye"
                }
            },
            {
                "んしょ", new[]
                {
                    "nsyo", "nsho", "nsilyo", "nsixyo", "nshilyo", "nshixyo", "ncilyo", "ncixyo",
                    "nnsyo", "nnsho", "nnsilyo", "nnsixyo", "nnshilyo", "nnshixyo", "nncilyo", "nncixyo",
                    "xnsyo", "xnsho", "xnsilyo", "xnsixyo", "xnshilyo", "xnshixyo", "xncilyo", "xncixyo"
                }
            },
            {
                "んじゃ", new[]
                {
                    "nja", "njya", "nzya", "njilya", "njixya", "nzilya", "nzixya",
                    "nnja", "nnjya", "nnzya", "nnjilya", "nnjixya", "nnzilya", "nnzixya",
                    "xnja", "xnjya", "xnzya", "xnjilya", "xnjixya", "xnzilya", "xnzixya"
                }
            },
            {
                "んじぃ", new[]
                {
                    "njyi", "nzyi", "njili", "njixi", "njilyi", "njixyi", "nzili", "nzixi", "nzilyi", "nzixyi",
                    "nnjyi", "nnzyi", "nnjili", "nnjixi", "nnjilyi", "nnjixyi", "nnzili", "nnzixi", "nnzilyi",
                    "nnzixyi",
                    "xnjyi", "xnzyi", "xnjili", "xnjixi", "xnjilyi", "xnjixyi", "xnzili", "xnzixi", "xnzilyi", "xnzixyi"
                }
            },
            {
                "んじゅ", new[]
                {
                    "nju", "njyu", "nzyu", "njilyu", "njixyu", "nzilyu", "nzixyu",
                    "nnju", "nnjyu", "nnzyu", "nnjilyu", "nnjixyu", "nnzilyu", "nnzixyu",
                    "xnju", "xnjyu", "xnzyu", "xnjilyu", "xnjixyu", "xnzilyu", "xnzixyu"
                }
            },
            {
                "んじぇ", new[]
                {
                    "nje", "njye", "nzye", "njile", "njixe", "njilye", "njixye", "nzile", "nzixe", "nzilye", "nzixye",
                    "nnje", "nnjye", "nnzye", "nnjile", "nnjixe", "nnjilye", "nnjixye", "nnzile", "nnzixe", "nnzilye",
                    "nnzixye",
                    "xnje", "xnjye", "xnzye", "xnjile", "xnjixe", "xnjilye", "xnjixye", "xnzile", "xnzixe", "xnzilye",
                    "xnzixye"
                }
            },
            {
                "んじょ", new[]
                {
                    "njo", "njyo", "nzyo", "njilyo", "njixyo", "nzilyo", "nzixyo",
                    "nnjo", "nnjyo", "nnzyo", "nnjilyo", "nnjixyo", "nnzilyo", "nnzixyo",
                    "xnjo", "xnjyo", "xnzyo", "xnjilyo", "xnjixyo", "xnzilyo", "xnzixyo"
                }
            },
            {
                "んちゃ", new[]
                {
                    "ntya", "ncha", "ncya", "ntilya", "ntixya", "nchilya", "nchixya",
                    "nntya", "nncha", "nncya", "nntilya", "nntixya", "nnchilya", "nnchixya",
                    "xntya", "xncha", "xncya", "xntilya", "xntixya", "xnchilya", "xnchixya"
                }
            },
            {
                "んちぃ", new[]
                {
                    "ntyi", "ncyi", "ntili", "ntixi", "ntilyi", "ntixyi", "nchili", "nchixi", "nchilyi", "nchixyi",
                    "nntyi", "nncyi", "nntili", "nntixi", "nntilyi", "nntixyi", "nnchili", "nnchixi", "nnchilyi",
                    "nnchixyi",
                    "xntyi", "xncyi", "xntili", "xntixi", "xntilyi", "xntixyi", "xnchili", "xnchixi", "xnchilyi",
                    "xnchixyi"
                }
            },
            {
                "んちゅ", new[]
                {
                    "ntyu", "nchu", "ncyu", "ntilyu", "ntixyu", "nchilyu", "nchixyu",
                    "nntyu", "nnchu", "nncyu", "nntilyu", "nntixyu", "nnchilyu", "nnchixyu",
                    "xntyu", "xnchu", "xncyu", "xntilyu", "xntixyu", "xnchilyu", "xnchixyu"
                }
            },
            {
                "んちぇ", new[]
                {
                    "ntye", "nche", "ncye", "ntile", "ntixe", "ntilye", "ntixye", "nchile", "nchixe", "nchilye",
                    "nchixye",
                    "nntye", "nnche", "nncye", "nntile", "nntixe", "nntilye", "nntixye", "nnchile", "nnchixe",
                    "nnhilye", "nnchixye",
                    "xntye", "xnche", "xncye", "xntile", "xntixe", "xntilye", "xntixye", "xnchile", "xnchixe",
                    "xnchilye", "xnchixye"
                }
            },
            {
                "んちょ", new[]
                {
                    "ntyo", "ncho", "ncyo", "ntilyo", "ntixyo", "nchilyo", "nchixyo",
                    "nntyo", "nncho", "nncyo", "nntilyo", "nntixyo", "nnchilyo", "nnchixyo",
                    "xntyo", "xncho", "xncyo", "xntilyo", "xntixyo", "xnchilyo", "xnchixyo"
                }
            },
            {
                "んぢゃ",
                new[] {"ndya", "ndilya", "ndixya", "nndya", "nndilya", "nndixya", "xndya", "xndilya", "xndixya"}
            },
            {
                "んぢゅ",
                new[] {"ndyu", "ndilyu", "ndixyu", "nndyu", "nndilyu", "nndixyu", "xndyu", "xndilyu", "xndixyu"}
            },
            {
                "んぢぇ",
                new[]
                {
                    "ndye", "ndile", "ndixe", "ndilye", "ndixye", "nndye", "nndile", "nndixe", "nndilye", "nndixye",
                    "xndye", "xndile", "xndixe", "xndilye", "xndixye"
                }
            },
            {
                "んぢょ",
                new[] {"ndyo", "ndilyo", "ndixyo", "nndyo", "nndilyo", "nndixyo", "xndyo", "xndilyo", "xndixyo"}
            },
            {
                "んつぁ",
                new[]
                {
                    "ntsa", "ntula", "ntuxa", "ntsula", "ntsuxa", "nntsa", "nntula", "nntuxa", "nntsula", "nntsuxa",
                    "xntsa", "xntula", "xntuxa", "xntsula", "xntsuxa"
                }
            },
            {
                "んつぃ", new[]
                {
                    "ntsi", "ntuli", "ntuxi", "ntulyi", "ntuxyi", "ntsuli", "ntsuxi", "ntsulyi", "ntsuxyi",
                    "nntsi", "nntuli", "nntuxi", "nntulyi", "nntuxyi", "nntsuli", "nntsuxi", "nntsulyi", "nntsuxyi",
                    "xntsi", "xntuli", "xntuxi", "xntulyi", "xntuxyi", "xntsuli", "xntsuxi", "xntsulyi", "xntsuxyi"
                }
            },
            {
                "んつぇ", new[]
                {
                    "ntse", "ntule", "ntuxe", "ntulye", "ntuxye", "ntsule", "ntsuxe", "ntsulye", "ntsuxye",
                    "nntse", "nntule", "nntuxe", "nntulye", "nntuxye", "nntsule", "nntsuxe", "nntsulye", "nntsuxye",
                    "xntse", "xntule", "xntuxe", "xntulye", "xntuxye", "xntsule", "xntsuxe", "xntsulye", "xntsuxye"
                }
            },
            {
                "んつぉ",
                new[]
                {
                    "ntso", "ntulo", "ntuxo", "ntsulo", "ntsuxo", "nntso", "nntulo", "nntuxo", "nntsulo", "nntsuxo",
                    "xntso", "xntulo", "xntuxo", "xntsulo", "xntsuxo"
                }
            },
            {
                "んてゃ",
                new[] {"ntha", "ntelya", "ntexya", "nntha", "nntelya", "nntexya", "xntha", "xntelya", "xntexya"}
            },
            {
                "んてぃ",
                new[]
                {
                    "nthi", "nteli", "ntexi", "ntelyi", "ntexyi", "nnthi", "nnteli", "nntexi", "nntelyi", "nntexyi",
                    "xnthi", "xnteli", "xntexi", "xntelyi", "xntexyi"
                }
            },
            {
                "んてゅ",
                new[] {"nthu", "ntelyu", "ntexyu", "nnthu", "nntelyu", "nntexyu", "xnthu", "xntelyu", "xntexyu"}
            },
            {
                "んてぇ",
                new[]
                {
                    "nthe", "ntele", "ntexe", "ntelye", "ntexye", "nnthe", "nntele", "nntexe", "nntelye", "nntexye",
                    "xnthe", "xntele", "xntexe", "xntelye", "xntexye"
                }
            },
            {
                "んてょ",
                new[] {"ntho", "ntelyo", "ntexyo", "nntho", "nntelyo", "nntexyo", "xntho", "xntelyo", "xntexyo"}
            },
            {
                "んでゃ",
                new[] {"ndha", "ndelya", "ndexya", "nndha", "nndelya", "nndexya", "xndha", "xndelya", "xndexya"}
            },
            {
                "んでぃ",
                new[]
                {
                    "ndhi", "ndeli", "ndexi", "ndelyi", "ndexyi", "nndhi", "nndeli", "nndexi", "nndelyi", "nndexyi",
                    "xndhi", "xndeli", "xndexi", "xndelyi", "xndexyi"
                }
            },
            {
                "んでゅ",
                new[] {"ndhu", "ndelyu", "ndexyu", "nndhu", "nndelyu", "nndexyu", "xndhu", "xndelyu", "xndexyu"}
            },
            {
                "んでぇ",
                new[]
                {
                    "ndhe", "ndele", "ndexe", "ndelye", "ndexye", "nndhe", "nndele", "nndexe", "nndelye", "nndexye",
                    "xndhe", "xndele", "xndexe", "xndelye", "xndexye"
                }
            },
            {
                "んでょ",
                new[] {"ndho", "ndelyo", "ndexyo", "nndho", "nndelyo", "nndexyo", "xndho", "xndelyo", "xndexyo"}
            },
            {"んとぁ", new[] {"ntwa", "ntola", "ntoxa", "nntwa", "nntola", "nntoxa", "xntwa", "xntola", "xntoxa"}},
            {
                "んとぃ",
                new[]
                {
                    "ntwi", "ntoli", "ntoxi", "ntolyi", "ntoxyi", "nntwi", "nntoli", "nntoxi", "nntolyi", "nntoxyi",
                    "xntwi", "xntoli", "xntoxi", "xntolyi", "xntoxyi"
                }
            },
            {"んとぅ", new[] {"ntwu", "ntolu", "ntoxu", "nntwu", "nntolu", "nntoxu", "xntwu", "xntolu", "xntoxu"}},
            {
                "んとぇ",
                new[]
                {
                    "ntwe", "ntole", "ntoxe", "ntolye", "ntoxye", "nntwe", "nntole", "nntoxe", "nntolye", "nntoxye",
                    "xntwe", "xntole", "xntoxe", "xntolye", "xntoxye"
                }
            },
            {"んとぉ", new[] {"ntwo", "ntolo", "ntoxo", "nntwo", "nntolo", "nntoxo", "xntwo", "xntolo", "xntoxo"}},
            {"んどぁ", new[] {"ndwa", "ndola", "ndoxa", "nndwa", "nndola", "nndoxa", "xndwa", "xndola", "xndoxa"}},
            {
                "んどぃ",
                new[]
                {
                    "ndwi", "ndoli", "ndoxi", "ndolyi", "ndoxyi", "nndwi", "nndoli", "nndoxi", "nndolyi", "nndoxyi",
                    "xndwi", "xndoli", "xndoxi", "xndolyi", "xndoxyi"
                }
            },
            {"んどぅ", new[] {"ndwu", "ndolu", "ndoxu", "nndwu", "nndolu", "nndoxu", "xndwu", "xndolu", "xndoxu"}},
            {
                "んどぇ",
                new[]
                {
                    "ndwe", "ndole", "ndoxe", "ndolye", "ndoxye", "nndwe", "nndole", "nndoxe", "nndolye", "nndoxye",
                    "xndwe", "xndole", "xndoxe", "xndolye", "xndoxye"
                }
            },
            {"んどぉ", new[] {"ndwo", "ndolo", "ndoxo", "nndwo", "nndolo", "nndoxo", "xndwo", "xndolo", "xndoxo"}},
            {"んにゃ", new[] {"nnnya", "xnnya", "nnnixya", "xnnixya", "nnnilya", "xnnilya"}},
            {"んにゅ", new[] {"nnnyu", "xnnyu", "nnnixyu", "xnnixyu", "nnnilyu", "xnnilyu"}},
            {"んにょ", new[] {"nnnyo", "xnnyo", "nnnixyo", "xnnixyo", "nnnilyo", "xnnilyo"}},
            {
                "んぴゃ",
                new[] {"npya", "npilya", "npixya", "nnpya", "nnpilya", "nnpixya", "xnpya", "xnpilya", "xnpixya"}
            },
            {
                "んぴぃ",
                new[]
                {
                    "npyi", "npili", "npixi", "npilyi", "npixyi", "nnpyi", "nnpili", "nnpixi", "nnpilyi", "nnpixyi",
                    "xnpyi", "xnpili", "xnpixi", "xnpilyi", "xnpixyi"
                }
            },
            {
                "んぴゅ",
                new[] {"npyu", "npilyu", "npixyu", "nnpyu", "nnpilyu", "nnpixyu", "xnpyu", "xnpilyu", "xnpixyu"}
            },
            {
                "んぴぇ",
                new[]
                {
                    "npye", "npile", "npixe", "npilye", "npixye", "nnpye", "nnpile", "nnpixe", "nnpilye", "nnpixye",
                    "xnpye", "xnpile", "xnpixe", "xnpilye", "xnpixye"
                }
            },
            {
                "んぴょ",
                new[] {"npyo", "npilyo", "npixyo", "nnpyo", "nnpilyo", "nnpixyo", "xnpyo", "xnpilyo", "xnpixyo"}
            },
            {
                "んひゃ",
                new[] {"nhya", "nhilya", "nhixya", "nnhya", "nnhilya", "nnhixya", "xnhya", "xnhilya", "xnhixya"}
            },
            {
                "んひぃ",
                new[]
                {
                    "nhyi", "nhili", "nhixi", "nhilyi", "nhixyi", "nnhyi", "nnhili", "nnhixi", "nnhilyi", "nnhixyi",
                    "xnhyi", "xnhili", "xnhixi", "xnhilyi", "xnhixyi"
                }
            },
            {
                "んひゅ",
                new[] {"nhyu", "nhilyu", "nhixyu", "nnhyu", "nnhilyu", "nnhixyu", "xnhyu", "xnhilyu", "xnhixyu"}
            },
            {
                "んひぇ",
                new[]
                {
                    "nhye", "nhile", "nhixe", "nhilye", "nhixye", "nnhye", "nnhile", "nnhixe", "nnhilye", "nnhixye",
                    "xnhye", "xnhile", "xnhixe", "xnhilye", "xnhixye"
                }
            },
            {
                "んひょ",
                new[] {"nhyo", "nhilyo", "nhixyo", "nnhyo", "nnhilyo", "nnhixyo", "xnhyo", "xnhilyo", "xnhixyo"}
            },
            {
                "んびゃ",
                new[] {"nbya", "nbilya", "nbixya", "nnbya", "nnbilya", "nnbixya", "xnbya", "xnbilya", "xnbixya"}
            },
            {
                "んびぃ",
                new[]
                {
                    "nbyi", "nbili", "nbixi", "nbilyi", "nbixyi", "nnbyi", "nnbili", "nnbixi", "nnbilyi", "nnbixyi",
                    "xnbyi", "xnbili", "xnbixi", "xnbilyi", "xnbixyi"
                }
            },
            {
                "んびゅ",
                new[] {"nbyu", "nbilyu", "nbixyu", "nnbyu", "nnbilyu", "nnbixyu", "xnbyu", "xnbilyu", "xnbixyu"}
            },
            {
                "んびぇ",
                new[]
                {
                    "nbye", "nbile", "nbixe", "nbilye", "nbixye", "nnbye", "nnbile", "nnbixe", "nnbilye", "nnbixye",
                    "xnbye", "xnbile", "xnbixe", "xnbilye", "xnbixye"
                }
            },
            {
                "んびょ",
                new[] {"nbyo", "nbilyo", "nbixyo", "nnbyo", "nnbilyo", "nnbixyo", "xnbyo", "xnbilyo", "xnbixyo"}
            },
            {
                "んふゃ",
                new[]
                {
                    "nfya", "nfulya", "nfuxya", "nhulya", "nhuxya", "nnfya", "nnfulya", "nnfuxya", "nnhulya", "nnhuxya",
                    "xnfya", "xnfulya", "xnfuxya", "xnhulya", "xnhuxya"
                }
            },
            {
                "んふぃ", new[]
                {
                    "nfi", "nfyi", "nfuli", "nfuxi", "nfulyi", "nfuxyi", "nhuli", "nhuxi", "nhulyi", "nhuxyi",
                    "nnfi", "nnfyi", "nnfuli", "nnfuxi", "nnfulyi", "nnfuxyi", "nnhuli", "nnhuxi", "nnhulyi", "nnhuxyi",
                    "xnfi", "xnfyi", "xnfuli", "xnfuxi", "xnfulyi", "xnfuxyi", "xnhuli", "xnhuxi", "xnhulyi", "xnhuxyi"
                }
            },
            {
                "んふゅ",
                new[]
                {
                    "nfyu", "nfulyu", "nfuxyu", "nhulyu", "nhuxyu", "nnfyu", "nnfulyu", "nnfuxyu", "nnhulyu", "nnhuxyu",
                    "xnfyu", "xnfulyu", "xnfuxyu", "xnhulyu", "xnhuxyu"
                }
            },
            {
                "んふぇ", new[]
                {
                    "nfe", "nfye", "nfule", "nfuxe", "nfulye", "nfuxye", "nhule", "nhuxe", "nhulye", "nhuxye",
                    "nnfe", "nnfye", "nnfule", "nnfuxe", "nnfulye", "nnfuxye", "nnhule", "nnhuxe", "nnhulye", "nnhuxye",
                    "xnfe", "xnfye", "xnfule", "xnfuxe", "xnfulye", "xnfuxye", "xnhule", "xnhuxe", "xnhulye", "xnhuxye"
                }
            },
            {
                "んふょ",
                new[]
                {
                    "nfyo", "nfulyo", "nfuxyo", "nhulyo", "nhuxyo", "nnfyo", "nnfulyo", "nnfuxyo", "nnhulyo", "nnhuxyo",
                    "xnfyo", "xnfulyo", "xnfuxyo", "xnhulyo", "xnhuxyo"
                }
            },
            {
                "んふぁ",
                new[]
                {
                    "nfa", "nfula", "nfuxa", "nhula", "nhuxa", "nnfa", "nnfula", "nnfuxa", "nnhula", "nnhuxa", "xnfa",
                    "xnfula", "xnfuxa", "xnhula", "xnhuxa"
                }
            },
            {
                "んふぉ",
                new[]
                {
                    "nfo", "nfulo", "nfuxo", "nhulo", "nhuxo", "nnfo", "nnfulo", "nnfuxo", "nnhulo", "nnhuxo", "xnfo",
                    "xnfulo", "xnfuxo", "xnhulo", "xnhuxo"
                }
            },
            {
                "んみゃ",
                new[] {"nmya", "nmilya", "nmixya", "nnmya", "nnmilya", "nnmixya", "xnmya", "xnmilya", "xnmixya"}
            },
            {
                "んみぃ",
                new[]
                {
                    "nmyi", "nmili", "nmixi", "nmilyi", "nmixyi", "nnmyi", "nnmili", "nnmixi", "nnmilyi", "nnmixyi",
                    "xnmyi", "xnmili", "xnmixi", "xnmilyi", "xnmixyi"
                }
            },
            {
                "んみゅ",
                new[] {"nmyu", "nmilyu", "nmixyu", "nnmyu", "nnmilyu", "nnmixyu", "xnmyu", "xnmilyu", "xnmixyu"}
            },
            {
                "んみぇ",
                new[]
                {
                    "nmye", "nmile", "nmixe", "nmilye", "nmixye", "nnmye", "nnmile", "nnmixe", "nnmilye", "nnmixye",
                    "xnmye", "xnmile", "xnmixe", "xnilye", "xnmixye"
                }
            },
            {
                "んみょ",
                new[] {"nmyo", "nmilyo", "nmixyo", "nnmyo", "nnmilyo", "nnmixyo", "xnmyo", "xnmilyo", "xnmixyo"}
            },
            {
                "んりゃ",
                new[] {"nrya", "nrilya", "nrixya", "nnrya", "nnrilya", "nnrixya", "xnrya", "xnrilya", "xnrixya"}
            },
            {
                "んりぃ",
                new[]
                {
                    "nryi", "nrili", "nrixi", "nrilyi", "nrixyi", "nnryi", "nnrili", "nnrixi", "nnrilyi", "nnrixyi",
                    "xnryi", "xnrili", "xnrixi", "xnrilyi", "xnrixyi"
                }
            },
            {
                "んりゅ",
                new[] {"nryu", "nrilyu", "nrixyu", "nnryu", "nnrilyu", "nnrixyu", "xnryu", "xnrilyu", "xnrixyu"}
            },
            {
                "んりぇ",
                new[]
                {
                    "nrye", "nrile", "nrixe", "nrilye", "nrixye", "nnrye", "nnrile", "nnrixe", "nnrilye", "nnrixye",
                    "xnrye", "xnrile", "xnrixe", "xnrilye", "xnrixye"
                }
            },
            {
                "んりょ",
                new[] {"nryo", "nrilyo", "nrixyo", "nnryo", "nnrilyo", "nnrixyo", "xnryo", "xnrilyo", "xnrixyo"}
            },
            {
                "んうぁ", new[]
                {
                    "nwha", "nula", "nuxa", "nwula", "nwuxa", "nwhula", "nwhuxa",
                    "nnwha", "nnula", "nnuxa", "nnwula", "nnwuxa", "nnwhula", "nnwhuxa",
                    "xnwha", "xnula", "xnuxa", "xnwula", "xnwuxa", "xnwhula", "xnwhuxa"
                }
            },
            {
                "んうぃ", new[]
                {
                    "nwi", "nwhi", "nuli", "nuxi", "nulyi", "nuxyi", "nwuli", "nwuxi", "nwulyi", "nwuxyi", "nwhuli",
                    "nnwi", "nnwhi", "nnuli", "nnuxi", "nnulyi", "nnuxyi", "nnwuli", "nnwuxi", "nnwulyi", "nnwuxyi",
                    "nnwhuli",
                    "xnwi", "xnwhi", "xnuli", "xnuxi", "xnulyi", "xnuxyi", "xnwuli", "xnwuxi", "xnwulyi", "xnwuxyi",
                    "xnwhuli"
                }
            },
            {
                "んうぇ", new[]
                {
                    "nwe", "nwhe", "nule", "nuxe", "nulye", "nuxye", "nwule", "nwuxe", "nwulye", "nwuxye", "nwhule",
                    "nwhuxe", "nwhulye", "nwhuxye",
                    "nnwe", "nnwhe", "nnule", "nnuxe", "nnulye", "nnuxye", "nnwule", "nnwuxe", "nnwulye", "nnwuxye",
                    "nnwhule", "nnwhuxe", "nnwhulye", "nnwhuxye",
                    "xnwe", "xnwhe", "xnule", "xnuxe", "xnulye", "xnuxye", "xnwule", "xnwuxe", "xnwulye", "xnwuxye",
                    "xnwhule", "xnwhuxe", "xnwhulye", "xnwhuxye"
                }
            },
            {
                "んうぉ", new[]
                {
                    "nwho", "nulo", "nuxo", "nwulo", "nwuxo", "nwhulo", "nwhuxo",
                    "nnwho", "nnulo", "nnuxo", "nnwulo", "nnwuxo", "nnwhulo", "nnwhuxo",
                    "xnwho", "xnulo", "xnuxo", "xnwulo", "xnwuxo", "xnwhulo", "xnwhuxo"
                }
            },
            {"んゔぁ", new[] {"nva", "nvula", "nvuxa", "nnva", "nnvula", "nnvuxa", "xnva", "xnvula", "xnvuxa"}},
            {
                "んゔぃ",
                new[]
                {
                    "nvi", "nvyi", "nvuli", "nvuxi", "nvulyi", "nvuxyi", "nnvi", "nnvyi", "nnvuli", "nnvuxi", "nnvulyi",
                    "nnvuxyi", "xnvi", "xnvyi", "xnvuli", "xnvuxi", "xnvulyi", "xnvuxyi"
                }
            },
            {"んゔ", new[] {"nvu", "nnvu", "xnvu"}},
            {
                "んゔぇ",
                new[]
                {
                    "nve", "nvye", "nvule", "nvuxe", "nvulye", "nvuxye", "nnve", "nnvye", "nnvule", "nnvuxe", "nnvulye",
                    "nnvuxye", "xnve", "xnvye", "xnvule", "xnvuxe", "xnvulye", "xnvuxye"
                }
            },
            {"んゔぉ", new[] {"nvo", "nvulo", "nvuxo", "nnvo", "nnvulo", "nnvuxo", "xnvo", "xnvulo", "xnvuxo"}},
            {
                "んゔゃ",
                new[] {"nvya", "nvulya", "nvuxya", "nnvya", "nnvulya", "nnvuxya", "xnvya", "xnvulya", "xnvuxya"}
            },
            {
                "んゔゅ",
                new[] {"nvyu", "nvulyu", "nvuxyu", "nnvyu", "nnvulyu", "nnvuxyu", "xnvyu", "xnvulyu", "xnvuxyu"}
            },
            {
                "んゔょ",
                new[] {"nvyo", "nvulyo", "nvuxyo", "nnvyo", "nnvulyo", "nnvuxyo", "xnvyo", "xnvulyo", "xnvuxyo"}
            },
            {"んゐ", new[] {"nwyi", "nnwyi", "xnwyi"}},
            {"んゑ", new[] {"nwye", "nnwye", "xnwye"}},
            {"ん、", new[] {"n,", "nn,", "xn,"}},
            {
                "っか",
                new[]
                    {"kka", "cca", "ltuka", "xtuka", "ltsuka", "xtsuka", "ltuca", "xtuca", "ltsuca", "xtsuca"}
            },
            {"っき", new[] {"kki", "ltuki", "xtuki", "ltsuki", "xtsuki"}},
            {
                "っく",
                new[]
                    {"kku", "ccu", "ltuku", "xtuku", "ltsuku", "xtsuku", "ltucu", "xtucu", "ltsucu", "xtsucu"}
            },
            {"っけ", new[] {"kke", "ltuke", "xtuke", "ltsuke", "xtsuke"}},
            {
                "っこ",
                new[]
                    {"kko", "cco", "ltuko", "xtuko", "ltsuko", "xtsuko", "ltuco", "xtuco", "ltsuco", "xtsuco"}
            },
            {"っさ", new[] {"ssa", "ltusa", "xtusa", "ltsusa", "xtsusa"}},
            {
                "っし",
                new[]
                {
                    "ssi", "cci", "sshi", "ltusi", "xtsusi", "ltsusi", "xtsusi", "ltuci", "xtuci", "ltsuci", "xtsuci",
                    "ltushi", "xtushi", "ltsushi", "xtsushi"
                }
            },
            {"っす", new[] {"ssu", "ltusu", "xtusu", "ltsusu", "xtsusu"}},
            {
                "っせ",
                new[]
                    {"sse", "cce", "ltuse", "xtuse", "ltsuse", "xtsuse", "ltuce", "xtuce", "ltsuce", "xtsuce"}
            },
            {"っそ", new[] {"sso", "ltuso", "xtuso", "ltsuso", "xtsuso"}},
            {"った", new[] {"tta", "ltuta", "xtuta", "ltsuta", "xtsuta"}},
            {
                "っち",
                new[]
                    {"tti", "cchi", "ltuti", "xtuti", "ltsuti", "xtsuti", "ltuchi", "xtuchi", "ltsuchi", "xtsuchi"}
            },
            {
                "っつ",
                new[]
                    {"ttu", "ttsu", "ltutu", "xtutu", "ltsutu", "xtsutu", "ltutsu", "xtutsu", "ltsutsu", "xtsutsu"}
            },
            {"って", new[] {"tte", "ltute", "xtute", "ltsute", "xtsute"}},
            {"っと", new[] {"tto", "ltuto", "xtuto", "ltsuto", "xtsuto"}},
            {"っな", new[] {"ltuna", "xtuna", "ltsuna", "xtsuna"}},
            {"っに", new[] {"ltuni", "xtuni", "ltsuni", "xtsuni"}},
            {"っぬ", new[] {"ltunu", "xtunu", "ltsunu", "xtsunu"}},
            {"っね", new[] {"ltune", "xtune", "ltsune", "xtsune"}},
            {"っの", new[] {"ltuno", "xtuno", "ltsuno", "xtsuno"}},
            {"っは", new[] {"hha", "ltuha", "xtuha", "ltsuha", "xtsuha"}},
            {"っひ", new[] {"hhi", "ltuhi", "xtuhi", "ltsuhi", "xtsuhi"}},
            {
                "っふ",
                new[]
                    {"ffu", "hhu", "ltufu", "xtufu", "ltsufu", "xtsufu", "ltuhu", "xtuhu", "ltsuhu", "xtsuhu"}
            },
            {"っへ", new[] {"hhe", "ltuhe", "xtuhe", "ltsuhe", "xtsuhe"}},
            {"っほ", new[] {"hho", "ltuho", "xtuho", "ltsuho", "xtsuho"}},
            {"っま", new[] {"mma", "ltuma", "xtuma", "ltsuma", "xtsuma"}},
            {"っみ", new[] {"mmi", "ltumi", "xtumi", "ltsumi", "xtsumi"}},
            {"っむ", new[] {"mmu", "ltumu", "xtumu", "ltsumu", "xtsumu"}},
            {"っめ", new[] {"mme", "ltume", "xtume", "ltsume", "xtsume"}},
            {"っも", new[] {"mmo", "ltumo", "xtumo", "ltsumo", "xtsumo"}},
            {"っや", new[] {"yya", "ltuya", "xtuya", "ltsuya", "xtsuya"}},
            {"っゆ", new[] {"yyu", "ltuyu", "xtuyu", "ltsuyu", "xtsuyu"}},
            {"っよ", new[] {"yyo", "ltuyo", "xtuyo", "ltsuyo", "xtsuyo"}},
            {"っら", new[] {"rra", "ltura", "xtura", "ltsura", "xtsura"}},
            {"っり", new[] {"rri", "lturi", "xturi", "ltsuri", "xtsuri"}},
            {"っる", new[] {"rru", "lturu", "xturu", "ltsuru", "xtsuru"}},
            {"っれ", new[] {"rre", "lture", "xture", "ltsure", "xtsure"}},
            {"っろ", new[] {"rro", "lturo", "xturo", "ltsuro", "xtsuro"}},
            {"っわ", new[] {"wwa", "ltuwa", "xtuwa", "ltsuwa", "xtsuwa"}},
            {"っを", new[] {"wwo", "ltuwo", "xtuwo", "ltsuwo", "xtsuwo"}},
            {"っが", new[] {"gga", "ltuga", "xtuga", "ltsuga", "xtsuga"}},
            {"っぎ", new[] {"ggi", "ltugi", "xtugi", "ltsugi", "xtsugi"}},
            {"っぐ", new[] {"ggu", "ltugu", "xtugu", "ltsugu", "xtsugu"}},
            {"っげ", new[] {"gge", "ltuge", "xtuge", "ltsuge", "xtsuge"}},
            {"っご", new[] {"ggo", "ltugo", "xtugo", "ltsugo", "xtsugo"}},
            {"っざ", new[] {"zza", "ltuza", "xtuza", "ltsuza", "xtsuza"}},
            {
                "っじ",
                new[]
                    {"jji", "zzi", "ltuji", "xtuji", "ltsuji", "xtsuji", "ltuzi", "xtuzi", "ltsuzi", "xtsuzi"}
            },
            {"っず", new[] {"zzu", "ltuzu", "xtuzu", "ltsuzu", "xtsuzu"}},
            {"っぜ", new[] {"zze", "ltuze", "xtuze", "ltsuze", "xtsuze"}},
            {"っぞ", new[] {"zzo", "ltuzo", "xtuzo", "ltsuzo", "xtsuzo"}},
            {"っだ", new[] {"dda", "ltuda", "xtuda", "ltsuda", "xtsuda"}},
            {"っぢ", new[] {"ddi", "ltudi", "xtudi", "ltsudi", "xtsudi"}},
            {"っづ", new[] {"ddu", "ltudu", "xtudu", "ltsudu", "xtsudu"}},
            {"っで", new[] {"dde", "ltude", "xtude", "ltsude", "xtsude"}},
            {"っど", new[] {"ddo", "ltudo", "xtudo", "ltsudo", "xtsudo"}},
            {"っば", new[] {"bba", "ltuba", "xtuba", "ltsuba", "xtsuba"}},
            {"っび", new[] {"bbi", "ltubi", "xtubi", "ltsubi", "xtsubi"}},
            {"っぶ", new[] {"bbu", "ltubu", "xtubu", "ltsubu", "xtsubu"}},
            {"っべ", new[] {"bbe", "ltube", "xtube", "ltsube", "xtsube"}},
            {"っぼ", new[] {"bbo", "ltubo", "xtubo", "ltsubo", "xtsubo"}},
            {"っぱ", new[] {"ppa", "ltupa", "xtupa", "ltsupa", "xtsupa"}},
            {"っぴ", new[] {"ppi", "ltupi", "xtupi", "ltsupi", "xtsupi"}},
            {"っぷ", new[] {"ppu", "ltupu", "xtupu", "ltsupu", "xtsupu"}},
            {"っぺ", new[] {"ppe", "ltupe", "xtupe", "ltsupe", "xtsupe"}},
            {"っぽ", new[] {"ppo", "ltupo", "xtupo", "ltsupo", "xtsupo"}},
            {
                "っきゃ", new[]
                {
                    "kkya", "kkilya", "kkixya", "ltukya", "ltukilya", "ltukixya", "ltukya", "xtukilya", "xtukixya",
                    "xtukya", "xtukilya",
                    "ltsukixya", "ltsukya", "ltsukilya", "ltsukixya", "xtsukixya", "xtsukya", "xtsukilya", "xtsukixya"
                }
            },
            {
                "っきぃ", new[]
                {
                    "kkyi", "kkili", "kkilyi", "kkixi", "kkixyi", "ltukyi", "ltukili", "ltukilyi", "ltukixi",
                    "ltukixyi", "xtukyi", "xtukili", "xtukilyi", "xtukixi", "xtukixyi",
                    "ltsukyi", "ltsukili", "ltsukilyi", "ltsukixi", "ltsukixyi", "ltsukyi", "xtsukili", "xtsukilyi",
                    "xtsukixi", "xtsukixyi"
                }
            },
            {
                "っきゅ",
                new[]
                {
                    "kkyu", "kkilyu", "kkixyu", "ltukyu", "ltukilyu", "ltukixyu", "xtukyu", "xtukilyu", "xtukixyu",
                    "ltsukyu", "ltsukilyu", "ltsukixyu", "xtsukyu", "xtsukilyu", "xtsukixyu"
                }
            },
            {
                "っきょ",
                new[]
                {
                    "kkyo", "kkilyo", "kkixyo", "ltukyo", "xtukyo", "ltsukyo", "xtsukyo", "ltukilyo", "xtukilyo",
                    "ltsukilyo", "xtsukilyo", "ltukixyo", "xtukixyo", "ltsukixyo", "xtsukixyo"
                }
            },
            {
                "っぎゃ",
                new[]
                {
                    "ggya", "ggilya", "ggixya", "ltugya", "xtugya", "ltsugya", "xtsugya", "ltugilya", "xtugilya",
                    "ltsugilya", "xtsugilya", "ltugixya", "xtugixya", "ltsugixya", "xtsugixya"
                }
            },
            {
                "っぎゅ",
                new[]
                {
                    "ggyu", "ggilyu", "ggixyu", "ltugyu", "xtugyu", "ltsugyu", "xtsugyu", "ltugilyu", "xtugilyu",
                    "ltsugilyu", "xtsugilyu", "ltugixyu", "xtugixyu", "ltsugixyu", "xtsugixyu"
                }
            },
            {
                "っぎょ",
                new[]
                {
                    "ggyo", "ggilyo", "ggixyo", "ltugyo", "xtugyo", "ltsugyo", "xtsugyo", "ltugilyo", "xtugilyo",
                    "ltsugilyo", "xtsugilyo", "ltugixyo", "xtugixyo", "ltsugixyo", "xtsugixyo"
                }
            },
            {
                "っしゃ", new[]
                {
                    "ssya", "ssha", "ssilya", "ssixya", "sshilya", "sshixya", "ccilya", "ccixya", "ltusya", "xtusya",
                    "ltsusya", "xtsusya",
                    "ltusha", "xtusha", "ltsusha", "xtsusha", "ltusilya", "xtusilya", "ltsusilya", "xtsusilya",
                    "ltusixya", "xtusixya", "ltsusixya", "xtsusixya",
                    "ltushilya", "xtushilya", "ltsushilya", "xtsushilya", "ltushixya", "xtushixya", "ltsushixya",
                    "xtsushixya",
                    "ltucilya", "xtucilya", "ltsucilya", "xtsucilya", "ltucixya", "xtucixya", "ltsucixya", "xtsucixya"
                }
            },
            {
                "っしぃ", new[]
                {
                    "ssyi", "ssili", "ssixi", "ssilyi", "ssixyi", "sshili", "sshixi", "sshilyi", "sshixyi", "ccili",
                    "ccixi", "ccilyi", "ccixyi",
                    "ltusyi", "xtusyi", "ltsusyi", "xtsusyi",
                    "ltusili", "xtusili", "ltsusili", "xtsusili",
                    "ltusixi", "xtusixi", "ltsusixi", "xtsusixi",
                    "ltusilyi", "xtusilyi", "ltsusilyi", "xtsusilyi",
                    "ltusixyi", "xtusixyi", "ltsusixyi", "xtsusixyi",
                    "ltushili", "xtushili", "ltsushili", "xtsushili",
                    "ltushixi", "xtushixi", "ltsushixi", "xtsushixi",
                    "ltushilyi", "xtushilyi", "ltsushilyi", "xtsushilyi",
                    "ltushixyi", "xtushixyi", "ltsushixyi", "xtsushixyi",
                    "ltucili", "xtucili", "ltsucili", "xtsucili",
                    "ltucixi", "xtucixi", "ltsucixi", "xtsucixi",
                    "ltucilyi", "xtucilyi", "ltsucilyi", "xtsucilyi",
                    "ltucixyi", "xtucixyi", "ltsucixyi", "xtsucixyi"
                }
            },
            {
                "っしゅ", new[]
                {
                    "ssyu", "sshu", "ssilyu", "ssixyu", "sshilyu", "sshixyu", "ccilyu", "ccixyu", "ltusyu", "xtusyu",
                    "ltsusyu", "xtsusyu",
                    "ltushu", "xtushu", "ltsushu", "xtsushu",
                    "ltusilyu", "xtusilyu", "ltsusilyu", "xtsusilyu",
                    "ltusixyu", "xtusixyu", "ltsusixyu", "xtsusixyu",
                    "ltushilyu", "xtushilyu", "ltsushilyu", "xtsushilyu",
                    "ltushixyu", "xtushixyu", "ltsushixyu", "xtsushixyu",
                    "ltucilyu", "xtucilyu", "ltsucilyu", "xtsucilyu",
                    "ltucixyu", "xtucixyu", "ltsucixyu", "xtsucixyu"
                }
            },
            {
                "っしぇ", new[]
                {
                    "ssye", "sshe", "ssile", "ssilye", "ssixe", "ssixye", "sshile", "sshilye", "sshixe", "sshixye",
                    "ccile", "ccilye", "ccixe", "ccixye", "ltusye", "xtusye", "ltsusye", "xtsusye",
                    "ltushe", "xtushe", "ltsushe", "xtsushe",
                    "ltusile", "xtusile", "ltsusile", "xtsusile",
                    "ltusilye", "xtusilye", "ltsusilye", "xtsusilye",
                    "ltusixe", "xtusixe", "ltsusixe", "xtsusixe",
                    "ltusixye", "xtusixye", "ltsusixye", "xtsusixye",
                    "ltushile", "xtushile", "ltsushile", "xtsushile",
                    "ltushilye", "xtushilye", "ltsushilye", "xtsushilye",
                    "ltushixe", "xtushixe", "ltsushixe", "xtsushixe",
                    "ltushixye", "xtushixye", "ltsushixye", "xtsushixye",
                    "ltucile", "xtucile", "ltsucile", "xtsucile",
                    "ltucilye", "xtucilye", "ltsucilye", "xtsucilye",
                    "ltucixe", "xtucixe", "ltsucixe", "xtsucixe",
                    "ltucixye", "xtucixye", "ltsucixye", "xtsucixye"
                }
            },
            {
                "っしょ", new[]
                {
                    "ssyo", "ssho", "ssilyo", "ssixyo", "sshilyo", "sshixyo", "ccilyo", "ccixyo", "ltusyo", "xtusyo",
                    "ltsusyo", "xtsusyo",
                    "ltusho", "xtusho", "ltsusho", "xtsusho",
                    "ltusilyo", "xtusilyo", "ltsusilyo", "xtsusilyo",
                    "ltusixyo", "xtusixyo", "ltsusixyo", "xtsusixyo",
                    "ltushilyo", "xtushilyo", "ltsushilyo", "xtsushilyo",
                    "ltushixyo", "xtushixyo", "ltsushixyo", "xtsushixyo",
                    "ltucilyo", "xtucilyo", "ltsucilyo", "xtsucilyo",
                    "ltucixyo", "xtucixyo", "ltsucixyo", "xtsucixyo"
                }
            },
            {
                "っじゃ", new[]
                {
                    "jja", "jjya", "zzya", "jjilya", "jjixya", "zzilya", "zzixya", "ltuja", "xtuja", "ltsuja", "xtsuja",
                    "ltujya", "xtujya", "ltsujya", "xtsujya",
                    "ltuzya", "xtuzya", "ltsuzya", "xtsuzya",
                    "ltujilya", "xtujilya", "ltsujilya", "xtsujilya",
                    "ltujixya", "xtujixya", "ltsujixya", "xtsujixya",
                    "ltuzilya", "xtuzilya", "ltsuzilya", "xtsuzilya",
                    "ltuzixya", "xtuzixya", "ltsuzixya", "xtsuzixya"
                }
            },
            {
                "っじぃ", new[]
                {
                    "jjyi", "zzyi", "jjili", "jjixi", "jjilyi", "jjixyi", "zzili", "zzixi", "zzilyi", "zzixyi",
                    "ltujyi", "xtujyi", "ltsujyi", "xtsujyi",
                    "ltuzyi", "xtuzyi", "ltsuzyi", "xtsuzyi",
                    "ltujili", "xtujili", "ltsujili", "xtsujili",
                    "ltujixi", "xtujixi", "ltsujixi", "xtsujixi",
                    "ltujilyi", "xtujilyi", "ltsujilyi", "xtsujilyi",
                    "ltujixyi", "xtujixyi", "ltsujixyi", "xtsujixyi",
                    "ltuzili", "xtuzili", "ltsuzili", "xtsuzili",
                    "ltuzixi", "xtuzixi", "ltsuzixi", "xtsuzixi",
                    "ltuzilyi", "xtuzilyi", "ltsuzilyi", "xtsuzilyi",
                    "ltuzixyi", "xtuzixyi", "ltsuzixyi", "xtsuzixyi"
                }
            },
            {
                "っじゅ", new[]
                {
                    "jju", "jjyu", "zzyu", "jjilyu", "jjixyu", "zzilyu", "zzixyu", "ltuju", "xtuju", "ltsuju", "xtsuju",
                    "ltujyu", "xtujyu", "ltsujyu", "xtsujyu",
                    "ltuzyu", "xtuzyu", "ltsuzyu", "xtsuzyu",
                    "ltujilyu", "xtujilyu", "ltsujilyu", "xtsujilyu",
                    "ltujixyu", "xtujixyu", "ltsujixyu", "xtsujixyu",
                    "ltuzilyu", "xtuzilyu", "ltsuzilyu", "xtsuzilyu",
                    "ltuzixyu", "xtuzixyu", "ltsuzixyu", "xtsuzixyu"
                }
            },
            {
                "っじぇ", new[]
                {
                    "jje", "jjye", "zzye", "jjile", "jjixe", "jjilye", "jjixye", "zzile", "zzixe", "zzilye", "zzixye",
                    "ltuje", "xtuje", "ltsuje", "xtsuje",
                    "ltujye", "xtujye", "ltsujye", "xtsujye",
                    "ltuzye", "xtuzye", "ltsuzye", "xtsuzye",
                    "ltujile", "xtujile", "ltsujile", "xtsujile",
                    "ltujixe", "xtujixe", "ltsujixe", "xtsujixe",
                    "ltujilye", "xtujilye", "ltsujilye", "xtsujilye",
                    "ltujixye", "xtujixye", "ltsujixye", "xtsujixye",
                    "ltuzile", "xtuzile", "ltsuzile", "xtsuzile",
                    "ltuzixe", "xtuzixe", "ltsuzixe", "xtsuzixe",
                    "ltuzilye", "xtuzilye", "ltsuzilye", "xtsuzilye",
                    "ltuzixye", "xtuzixye", "ltsuzixye", "xtsuzixye"
                }
            },
            {
                "っじょ", new[]
                {
                    "jjo", "jjyo", "zzyo", "jjilyo", "jjixyo", "zzilyo", "zzixyo", "ltujo", "xtujo", "ltsujo", "xtsujo",
                    "ltujyo", "xtujyo", "ltsujyo", "xtsujyo",
                    "ltuzyo", "xtuzyo", "ltsuzyo", "xtsuzyo",
                    "ltujilyo", "xtujilyo", "ltsujilyo", "xtsujilyo",
                    "ltujixyo", "xtujixyo", "ltsujixyo", "xtsujixyo",
                    "ltuzilyo", "xtuzilyo", "ltsuzilyo", "xtsuzilyo",
                    "ltuzixyo", "xtuzixyo", "ltsuzixyo", "xtsuzixyo"
                }
            },
            {
                "っちゃ", new[]
                {
                    "ttya", "ccha", "ccya", "ttilya", "ttixya", "cchilya", "cchixya", "ltutya", "xtutya", "ltsutya",
                    "xtsutya",
                    "ltucha", "xtucha", "ltsucha", "xtsucha",
                    "ltucya", "xtucya", "ltsucya", "xtsucya",
                    "ltutilya", "xtutilya", "ltsutilya", "xtsutilya",
                    "ltutixya", "xtutixya", "ltsutixya", "xtsutixya",
                    "ltuchilya", "xtuchilya", "ltsuchilya", "xtsuchilya",
                    "ltuchixya", "xtuchixya", "ltsuchixya", "xtsuchixya"
                }
            },
            {
                "っちぃ", new[]
                {
                    "ttyi", "ccyi", "ttili", "ttixi", "ttilyi", "ttixyi", "cchili", "cchixi", "cchilyi", "cchixyi",
                    "ltutyi", "xtutyi", "ltsutyi", "xtsutyi",
                    "ltucyi", "xtucyi", "ltsucyi", "xtsucyi",
                    "ltutili", "xtutili", "ltsutili", "xtsutili",
                    "ltutixi", "xtutixi", "ltsutixi", "xtsutixi",
                    "ltutilyi", "xtutilyi", "ltsutilyi", "xtsutilyi",
                    "ltutixyi", "xtutixyi", "ltsutixyi", "xtsutixyi",
                    "ltuchili", "xtuchili", "ltsuchili", "xtsuchili",
                    "ltuchixi", "xtuchixi", "ltsuchixi", "xtsuchixi",
                    "ltuchilyi", "xtuchilyi", "ltsuchilyi", "xtsuchilyi",
                    "ltuchixyi", "xtuchixyi", "ltsuchixyi", "xtsuchixyi"
                }
            },
            {
                "っちゅ", new[]
                {
                    "ttyu", "cchu", "ccyu", "ttilyu", "ttixyu", "cchilyu", "cchixyu", "ltutyu", "xtutyu", "ltsutyu",
                    "xtsutyu",
                    "ltuchu", "xtuchu", "ltsuchu", "xtsuchu",
                    "ltucyu", "xtucyu", "ltsucyu", "xtsucyu",
                    "ltutilyu", "xtutilyu", "ltsutilyu", "xtsutilyu",
                    "ltutixyu", "xtutixyu", "ltsutixyu", "xtsutixyu",
                    "ltuchilyu", "xtuchilyu", "ltsuchilyu", "xtsuchilyu",
                    "ltuchixyu", "xtuchixyu", "ltsuchixyu", "xtsuchixyu"
                }
            },
            {
                "っちぇ", new[]
                {
                    "ttye", "cche", "ccye", "ttile", "ttixe", "ttilye", "ttixye", "cchile", "cchixe", "cchilye",
                    "cchixye", "ltutye", "xtutye", "ltsutye", "xtsutye",
                    "ltuche", "xtuche", "ltsuche", "xtsuche",
                    "ltucye", "xtucye", "ltsucye", "xtsucye",
                    "ltutile", "xtutile", "ltsutile", "xtsutile",
                    "ltutixe", "xtutixe", "ltsutixe", "xtsutixe",
                    "ltutilye", "xtutilye", "ltsutilye", "xtsutilye",
                    "ltutixye", "xtutixye", "ltsutixye", "xtsutixye",
                    "ltuchile", "xtuchile", "ltsuchile", "xtsuchile",
                    "ltuchixe", "xtuchixe", "ltsuchixe", "xtsuchixe",
                    "ltuchilye", "xtuchilye", "ltsuchilye", "xtsuchilye",
                    "ltuchixye", "xtuchixye", "ltsuchixye", "xtsuchixye"
                }
            },
            {
                "っちょ", new[]
                {
                    "ttyo", "ccho", "ccyo", "ttilyo", "ttixyo", "cchilyo", "cchixyo", "ltutyo", "xtutyo", "ltsutyo",
                    "xtsutyo",
                    "ltucho", "xtucho", "ltsucho", "xtsucho",
                    "ltucyo", "xtucyo", "ltsucyo", "xtsucyo",
                    "ltutilyo", "xtutilyo", "ltsutilyo", "xtsutilyo",
                    "ltutixyo", "xtutixyo", "ltsutixyo", "xtsutixyo",
                    "ltuchilyo", "xtuchilyo", "ltsuchilyo", "xtsuchilyo",
                    "ltuchixyo", "xtuchixyo", "ltsuchixyo", "xtsuchixyo"
                }
            },
            {
                "っぢゃ", new[]
                {
                    "ddya", "ddilya", "ddixya", "ltudya", "xtudya", "ltsudya", "xtsudya",
                    "ltudilya", "xtudilya", "ltsudilya", "xtsudilya",
                    "ltudixya", "xtudixya", "ltsudixya", "xtsudixya"
                }
            },
            {
                "っぢゅ", new[]
                {
                    "ddyu", "ddilyu", "ddixyu", "ltudyu", "xtudyu", "ltsudyu", "xtsudyu",
                    "ltudilyu", "xtudilyu", "ltsudilyu", "xtsudilyu",
                    "ltudixyu", "xtudixyu", "ltsudixyu", "xtsudixyu"
                }
            },
            {
                "っぢぇ", new[]
                {
                    "ddye", "ddile", "ddixe", "ddilye", "ddixye", "ltudye", "xtudye", "ltsudye", "xtsudye",
                    "ltudile", "xtudile", "ltsudile", "xtsudile",
                    "ltudixe", "xtudixe", "ltsudixe", "xtsudixe",
                    "ltudilye", "xtudilye", "ltsudilye", "xtsudilye",
                    "ltudixye", "xtudixye", "ltsudixye", "xtsudixye"
                }
            },
            {
                "っぢょ", new[]
                {
                    "ddyo", "ddilyo", "ddixyo", "ltudyo", "xtudyo", "ltsudyo", "xtsudyo",
                    "ltudilyo", "xtudilyo", "ltsudilyo", "xtsudilyo",
                    "ltudixyo", "xtudixyo", "ltsudixyo", "xtsudixyo"
                }
            },
            {
                "っつぁ", new[]
                {
                    "ttsa", "ttula", "ttuxa", "ttsula", "ttsuxa", "ltutsa", "xtutsa", "ltsutsa", "xtsutsa",
                    "ltutula", "xtutula", "ltsutula", "xtsutula",
                    "ltutuxa", "xtutuxa", "ltsutuxa", "xtsutuxa",
                    "ltutsula", "xtutsula", "ltsutsula", "xtsutsula",
                    "ltutsuxa", "xtutsuxa", "ltsutsuxa", "xtsutsuxa"
                }
            },
            {
                "っつぃ", new[]
                {
                    "ttsi", "ttuli", "ttuxi", "ttulyi", "ttuxyi", "ttsuli", "ttsuxi", "ttsulyi", "ttsuxyi", "ltutsi",
                    "xtutsi", "ltsutsi", "xtsutsi",
                    "ltutuli", "xtutuli", "ltsutuli", "xtsutuli",
                    "ltutuxi", "xtutuxi", "ltsutuxi", "xtsutuxi",
                    "ltutulyi", "xtutulyi", "ltsutulyi", "xtsutulyi",
                    "ltutuxyi", "xtutuxyi", "ltsutuxyi", "xtsutuxyi",
                    "ltutsuli", "xtutsuli", "ltsutsuli", "xtsutsuli",
                    "ltutsuxi", "xtutsuxi", "ltsutsuxi", "xtsutsuxi",
                    "ltutsulyi", "xtutsulyi", "ltsutsulyi", "xtsutsulyi",
                    "ltutsuxyi", "xtutsuxyi", "ltsutsuxyi", "xtsutsuxyi"
                }
            },
            {
                "っつぇ", new[]
                {
                    "ttse", "ttule", "ttuxe", "ttulye", "ttuxye", "ttsule", "ttsuxe", "ttsulye", "ttsuxye", "ltutse",
                    "xtutse", "ltsutse", "xtsutse",
                    "ltutule", "xtutule", "ltsutule", "xtsutule",
                    "ltutuxe", "xtutuxe", "ltsutuxe", "xtsutuxe",
                    "ltutulye", "xtutulye", "ltsutulye", "xtsutulye",
                    "ltutuxye", "xtutuxye", "ltsutuxye", "xtsutuxye",
                    "ltutsule", "xtutsule", "ltsutsule", "xtsutsule",
                    "ltutsuxe", "xtutsuxe", "ltsutsuxe", "xtsutsuxe",
                    "ltutsulye", "xtutsulye", "ltsutsulye", "xtsutsulye",
                    "ltutsuxye", "xtutsuxye", "ltsutsuxye", "xtsutsuxye"
                }
            },
            {
                "っつぉ", new[]
                {
                    "ttso", "ttulo", "ttuxo", "ttsulo", "ttsuxo", "ltutso", "xtutso", "ltsutso", "xtsutso",
                    "ltutulo", "xtutulo", "ltsutulo", "xtsutulo",
                    "ltutuxo", "xtutuxo", "ltsutuxo", "xtsutuxo",
                    "ltutsulo", "xtutsulo", "ltsutsulo", "xtsutsulo",
                    "ltutsuxo", "xtutsuxo", "ltsutsuxo", "xtsutsuxo"
                }
            },
            {
                "ってゃ", new[]
                {
                    "ttha", "ttelya", "ttexya", "ltutha", "xtutha", "ltsutha", "xtsutha",
                    "ltutelya", "xtutelya", "ltsutelya", "xtsutelya",
                    "ltutexya", "xtutexya", "ltsutexya", "xtsutexya"
                }
            },
            {
                "ってぃ", new[]
                {
                    "tthi", "tteli", "ttexi", "ttelyi", "ttexyi", "ltuthi", "xtuthi", "ltsuthi", "xtsuthi",
                    "ltuteli", "xtuteli", "ltsuteli", "xtsuteli",
                    "ltutexi", "xtutexi", "ltsutexi", "xtsutexi",
                    "ltutelyi", "xtutelyi", "ltsutelyi", "xtsutelyi",
                    "ltutexyi", "xtutexyi", "ltsutexyi", "xtsutexyi"
                }
            },
            {
                "ってゅ", new[]
                {
                    "tthu", "ttelyu", "ttexyu", "ltuthu", "xtuthu", "ltsuthu", "xtsuthu",
                    "ltutelyu", "xtutelyu", "ltsutelyu", "xtsutelyu",
                    "ltutexyu", "xtutexyu", "ltsutexyu", "xtsutexyu"
                }
            },
            {
                "ってぇ", new[]
                {
                    "tthe", "ttele", "ttexe", "ttelye", "ttexye", "ltuthe", "xtuthe", "ltsuthe", "xtsuthe",
                    "ltutele", "xtutele", "ltsutele", "xtsutele",
                    "ltutexe", "xtutexe", "ltsutexe", "xtsutexe",
                    "ltutelye", "xtutelye", "ltsutelye", "xtsutelye",
                    "ltutexye", "xtutexye", "ltsutexye", "xtsutexye"
                }
            },
            {
                "ってょ", new[]
                {
                    "ttho", "ttelyo", "ttexyo", "ltutho", "xtutho", "ltsutho", "xtsutho",
                    "ltutelyo", "xtutelyo", "ltsutelyo", "xtsutelyo",
                    "ltutexyo", "xtutexyo", "ltsutexyo", "xtsutexyo"
                }
            },
            {
                "っでゃ", new[]
                {
                    "ddha", "ddelya", "ddexya", "ltudha", "xtudha", "ltsudha", "xtsudha",
                    "ltudelya", "xtudelya", "ltsudelya", "xtsudelya",
                    "ltudexya", "xtudexya", "ltsudexya", "xtsudexya"
                }
            },
            {
                "っでぃ", new[]
                {
                    "ddhi", "ddeli", "ddexi", "ddelyi", "ddexyi", "ltudhi", "xtudhi", "ltsudhi", "xtsudhi",
                    "ltudeli", "xtudeli", "ltsudeli", "xtsudeli",
                    "ltudexi", "xtudexi", "ltsudexi", "xtsudexi",
                    "ltudelyi", "xtudelyi", "ltsudelyi", "xtsudelyi",
                    "ltudexyi", "xtudexyi", "ltsudexyi", "xtsudexyi"
                }
            },
            {
                "っでゅ", new[]
                {
                    "ddhu", "ddelyu", "ddexyu", "ltudhu", "xtudhu", "ltsudhu", "xtsudhu",
                    "ltudelyu", "xtudelyu", "ltsudelyu", "xtsudelyu",
                    "ltudexyu", "xtudexyu", "ltsudexyu", "xtsudexyu"
                }
            },
            {
                "っでぇ", new[]
                {
                    "ddhe", "ddele", "ddexe", "ddelye", "ddexye", "ltudhe", "xtudhe", "ltsudhe", "xtsudhe",
                    "ltudele", "xtudele", "ltsudele", "xtsudele",
                    "ltudexe", "xtudexe", "ltsudexe", "xtsudexe",
                    "ltudelye", "xtudelye", "ltsudelye", "xtsudelye",
                    "ltudexye", "xtudexye", "ltsudexye", "xtsudexye"
                }
            },
            {
                "っでょ", new[]
                {
                    "ddho", "ddelyo", "ddexyo", "ltudho", "xtudho", "ltsudho", "xtsudho",
                    "ltudelyo", "xtudelyo", "ltsudelyo", "xtsudelyo",
                    "ltudexyo", "xtudexyo", "ltsudexyo", "xtsudexyo"
                }
            },
            {
                "っぴゃ", new[]
                {
                    "ppya", "ppilya", "ppixya", "ltupya", "xtupya", "ltsupya", "xtsupya",
                    "ltupilya", "xtupilya", "ltsupilya", "xtsupilya",
                    "ltupixya", "xtupixya", "ltsupixya", "xtsupixya"
                }
            },
            {
                "っぴぃ", new[]
                {
                    "ppyi", "ppili", "ppixi", "ppilyi", "ppixyi", "ltupyi", "xtupyi", "ltsupyi", "xtsupyi",
                    "ltupili", "xtupili", "ltsupili", "xtsupili",
                    "ltupixi", "xtupixi", "ltsupixi", "xtsupixi",
                    "ltupilyi", "xtupilyi", "ltsupilyi", "xtsupilyi",
                    "ltupixyi", "xtupixyi", "ltsupixyi", "xtsupixyi"
                }
            },
            {
                "っぴゅ", new[]
                {
                    "ppyu", "ppilyu", "ppixyu", "ltupyu", "xtupyu", "ltsupyu", "xtsupyu",
                    "ltupilyu", "xtupilyu", "ltsupilyu", "xtsupilyu",
                    "ltupixyu", "xtupixyu", "ltsupixyu", "xtsupixyu"
                }
            },
            {
                "っぴぇ", new[]
                {
                    "ppye", "ppile", "ppixe", "ppilye", "ppixye", "ltupye", "xtupye", "ltsupye", "xtsupye",
                    "ltupile", "xtupile", "ltsupile", "xtsupile",
                    "ltupixe", "xtupixe", "ltsupixe", "xtsupixe",
                    "ltupilye", "xtupilye", "ltsupilye", "xtsupilye",
                    "ltupixye", "xtupixye", "ltsupixye", "xtsupixye"
                }
            },
            {
                "っぴょ", new[]
                {
                    "ppyo", "ppilyo", "ppixyo", "ltupyo", "xtupyo", "ltsupyo", "xtsupyo",
                    "ltupilyo", "xtupilyo", "ltsupilyo", "xtsupilyo",
                    "ltupixyo", "xtupixyo", "ltsupixyo", "xtsupixyo"
                }
            },
            {
                "っひゃ", new[]
                {
                    "hhya", "hhilya", "hhixya", "ltuhya", "xtuhya", "ltsuhya", "xtsuhya",
                    "ltuhilya", "xtuhilya", "ltsuhilya", "xtsuhilya",
                    "ltuhixya", "xtuhixya", "ltsuhixya", "xtsuhixya"
                }
            },
            {
                "っひぃ", new[]
                {
                    "hhyi", "hhili", "hhixi", "hhilyi", "hhixyi", "ltuhyi", "xtuhyi", "ltsuhyi", "xtsuhyi",
                    "ltuhili", "xtuhili", "ltsuhili", "xtsuhili",
                    "ltuhixi", "xtuhixi", "ltsuhixi", "xtsuhixi",
                    "ltuhilyi", "xtuhilyi", "ltsuhilyi", "xtsuhilyi",
                    "ltuhixyi", "xtuhixyi", "ltsuhixyi", "xtsuhixyi"
                }
            },
            {
                "っひゅ", new[]
                {
                    "hhyu", "hhilyu", "hhixyu", "ltuhyu", "xtuhyu", "ltsuhyu", "xtsuhyu",
                    "ltuhilyu", "xtuhilyu", "ltsuhilyu", "xtsuhilyu",
                    "ltuhixyu", "xtuhixyu", "ltsuhixyu", "xtsuhixyu"
                }
            },
            {
                "っひぇ", new[]
                {
                    "hhye", "hhile", "hhixe", "hhilye", "hhixye", "ltuhye", "xtuhye", "ltsuhye", "xtsuhye",
                    "ltuhile", "xtuhile", "ltsuhile", "xtsuhile",
                    "ltuhixe", "xtuhixe", "ltsuhixe", "xtsuhixe",
                    "ltuhilye", "xtuhilye", "ltsuhilye", "xtsuhilye",
                    "ltuhixye", "xtuhixye", "ltsuhixye", "xtsuhixye"
                }
            },
            {
                "っひょ", new[]
                {
                    "hhyo", "hhilyo", "hhixyo", "ltuhyo", "xtuhyo", "ltsuhyo", "xtsuhyo",
                    "ltuhilyo", "xtuhilyo", "ltsuhilyo", "xtsuhilyo",
                    "ltuhixyo", "xtuhixyo", "ltsuhixyo", "xtsuhixyo"
                }
            },
            {
                "っびゃ", new[]
                {
                    "bbya", "bbilya", "bbixya", "ltubya", "xtubya", "ltsubya", "xtsubya",
                    "ltubilya", "xtubilya", "ltsubilya", "xtsubilya",
                    "ltubixya", "xtubixya", "ltsubixya", "xtsubixya"
                }
            },
            {
                "っびぃ", new[]
                {
                    "bbyi", "bbili", "bbixi", "bbilyi", "bbixyi", "ltubyi", "xtubyi", "ltsubyi", "xtsubyi",
                    "ltubili", "xtubili", "ltsubili", "xtsubili",
                    "ltubixi", "xtubixi", "ltsubixi", "xtsubixi",
                    "ltubilyi", "xtubilyi", "ltsubilyi", "xtsubilyi",
                    "ltubixyi", "xtubixyi", "ltsubixyi", "xtsubixyi"
                }
            },
            {
                "っびゅ", new[]
                {
                    "bbyu", "bbilyu", "bbixyu", "ltubyu", "xtubyu", "ltsubyu", "xtsubyu",
                    "ltubilyu", "xtubilyu", "ltsubilyu", "xtsubilyu",
                    "ltubixyu", "xtubixyu", "ltsubixyu", "xtsubixyu"
                }
            },
            {
                "っびぇ", new[]
                {
                    "bbye", "bbile", "bbixe", "bbilye", "bbixye", "ltubye", "xtubye", "ltsubye", "xtsubye",
                    "ltubile", "xtubile", "ltsubile", "xtsubile",
                    "ltubixe", "xtubixe", "ltsubixe", "xtsubixe",
                    "ltubilye", "xtubilye", "ltsubilye", "xtsubilye",
                    "ltubixye", "xtubixye", "ltsubixye", "xtsubixye"
                }
            },
            {
                "っびょ", new[]
                {
                    "bbyo", "bbilyo", "bbixyo", "ltubyo", "xtubyo", "ltsubyo", "xtsubyo",
                    "ltubilyo", "xtubilyo", "ltsubilyo", "xtsubilyo",
                    "ltubixyo", "xtubixyo", "ltsubixyo", "xtsubixyo"
                }
            },
            {
                "っふぁ", new[]
                {
                    "ffa", "ffula", "ffuxa", "hhula", "hhuxa", "ltufa", "xtufa", "ltsufa", "xtsufa",
                    "ltufula", "xtufula", "ltsufula", "xtsufula",
                    "ltufuxa", "xtufuxa", "ltsufuxa", "xtsufuxa",
                    "ltuhula", "xtuhula", "ltsuhula", "xtsuhula",
                    "ltuhuxa", "xtuhuxa", "ltsuhuxa", "xtsuhuxa"
                }
            },
            {
                "っふぃ", new[]
                {
                    "ffi", "ffyi", "ffuli", "ffuxi", "ffulyi", "ffuxyi", "hhuli", "hhuxi", "hhulyi", "hhuxyi", "ltufi",
                    "xtufi", "ltsufi", "xtsufi",
                    "ltufyi", "xtufyi", "ltsufyi", "xtsufyi",
                    "ltufuli", "xtufuli", "ltsufuli", "xtsufuli",
                    "ltufuxi", "xtufuxi", "ltsufuxi", "xtsufuxi",
                    "ltufulyi", "xtufulyi", "ltsufulyi", "xtsufulyi",
                    "ltufuxyi", "xtufuxyi", "ltsufuxyi", "xtsufuxyi",
                    "ltuhuli", "xtuhuli", "ltsuhuli", "xtsuhuli",
                    "ltuhuxi", "xtuhuxi", "ltsuhuxi", "xtsuhuxi",
                    "ltuhulyi", "xtuhulyi", "ltsuhulyi", "xtsuhulyi",
                    "ltuhuxyi", "xtuhuxyi", "ltsuhuxyi", "xtsuhuxyi"
                }
            },
            {
                "っふぇ", new[]
                {
                    "ffe", "ffye", "ffule", "ffuxe", "ffulye", "ffuxye", "hhule", "hhuxe", "hhulye", "hhuxye", "ltufe",
                    "xtufe", "ltsufe", "xtsufe",
                    "ltufye", "xtufye", "ltsufye", "xtsufye",
                    "ltufule", "xtufule", "ltsufule", "xtsufule",
                    "ltufuxe", "xtufuxe", "ltsufuxe", "xtsufuxe",
                    "ltufulye", "xtufulye", "ltsufulye", "xtsufulye",
                    "ltufuxye", "xtufuxye", "ltsufuxye", "xtsufuxye",
                    "ltuhule", "xtuhule", "ltsuhule", "xtsuhule",
                    "ltuhuxe", "xtuhuxe", "ltsuhuxe", "xtsuhuxe",
                    "ltuhulye", "xtuhulye", "ltsuhulye", "xtsuhulye",
                    "ltuhuxye", "xtuhuxye", "ltsuhuxye", "xtsuhuxye"
                }
            },
            {
                "っふぉ", new[]
                {
                    "ffo", "ffulo", "ffuxo", "hhulo", "hhuxo", "ltufo", "xtufo", "ltsufo", "xtsufo",
                    "ltufulo", "xtufulo", "ltsufulo", "xtsufulo",
                    "ltufuxo", "xtufuxo", "ltsufuxo", "xtsufuxo",
                    "ltuhulo", "xtuhulo", "ltsuhulo", "xtsuhulo",
                    "ltuhuxo", "xtuhuxo", "ltsuhuxo", "xtsuhuxo"
                }
            },
            {
                "っみゃ", new[]
                {
                    "mmya", "mmilya", "mmixya", "ltumya", "xtumya", "ltsumya", "xtsumya",
                    "ltumilya", "xtumilya", "ltsumilya", "xtsumilya",
                    "ltumixya", "xtumixya", "ltsumixya", "xtsumixya"
                }
            },
            {
                "っみぃ", new[]
                {
                    "mmyi", "mmili", "mmixi", "mmilyi", "mmixyi", "ltumyi", "xtumyi", "ltsumyi", "xtsumyi",
                    "ltumili", "xtumili", "ltsumili", "xtsumili",
                    "ltumixi", "xtumixi", "ltsumixi", "xtsumixi",
                    "ltumilyi", "xtumilyi", "ltsumilyi", "xtsumilyi",
                    "ltumixyi", "xtumixyi", "ltsumixyi", "xtsumixyi"
                }
            },
            {
                "っみゅ", new[]
                {
                    "mmyu", "mmilyu", "mmixyu", "ltumyu", "xtumyu", "ltsumyu", "xtsumyu",
                    "ltumilyu", "xtumilyu", "ltsumilyu", "xtsumilyu",
                    "ltumixyu", "xtumixyu", "ltsumixyu", "xtsumixyu"
                }
            },
            {
                "っみぇ", new[]
                {
                    "mmye", "mmile", "mmixe", "mmilye", "mmixye", "ltumye", "xtumye", "ltsumye", "xtsumye",
                    "ltumile", "xtumile", "ltsumile", "xtsumile",
                    "ltumixe", "xtumixe", "ltsumixe", "xtsumixe",
                    "ltumilye", "xtumilye", "ltsumilye", "xtsumilye",
                    "ltumixye", "xtumixye", "ltsumixye", "xtsumixye"
                }
            },
            {
                "っみょ", new[]
                {
                    "mmyo", "mmilyo", "mmixyo", "ltumyo", "xtumyo", "ltsumyo", "xtsumyo",
                    "ltumilyo", "xtumilyo", "ltsumilyo", "xtsumilyo",
                    "ltumixyo", "xtumixyo", "ltsumixyo", "xtsumixyo"
                }
            },
            {
                "っりゃ", new[]
                {
                    "rrya", "rrilya", "rrixya", "lturya", "xturya", "ltsurya", "xtsurya",
                    "lturilya", "xturilya", "ltsurilya", "xtsurilya",
                    "lturixya", "xturixya", "ltsurixya", "xtsurixya"
                }
            },
            {
                "っりぃ", new[]
                {
                    "rryi", "rrili", "rrixi", "rrilyi", "rrixyi", "lturyi", "xturyi", "ltsuryi", "xtsuryi",
                    "lturili", "xturili", "ltsurili", "xtsurili",
                    "lturixi", "xturixi", "ltsurixi", "xtsurixi",
                    "lturilyi", "xturilyi", "ltsurilyi", "xtsurilyi",
                    "lturixyi", "xturixyi", "ltsurixyi", "xtsurixyi"
                }
            },
            {
                "っりゅ", new[]
                {
                    "rryu", "rrilyu", "rrixyu", "lturyu", "xturyu", "ltsuryu", "xtsuryu",
                    "lturilyu", "xturilyu", "ltsurilyu", "xtsurilyu",
                    "lturixyu", "xturixyu", "ltsurixyu", "xtsurixyu"
                }
            },
            {
                "っりぇ", new[]
                {
                    "rrye", "rrile", "rrixe", "rrilye", "rrixye", "lturye", "xturye", "ltsurye", "xtsurye",
                    "lturile", "xturile", "ltsurile", "xtsurile",
                    "lturixe", "xturixe", "ltsurixe", "xtsurixe",
                    "lturilye", "xturilye", "ltsurilye", "xtsurilye",
                    "lturixye", "xturixye", "ltsurixye", "xtsurixye"
                }
            },
            {
                "っりょ", new[]
                {
                    "rryo", "rrilyo", "rrixyo", "lturyo", "xturyo", "ltsuryo", "xtsuryo",
                    "lturilyo", "xturilyo", "ltsurilyo", "xtsurilyo",
                    "lturixyo", "xturixyo", "ltsurixyo", "xtsurixyo"
                }
            },
            {"ー", new[] {"-"}}, {"、", new[] {","}}, {"。", new[] {"."}},
            {"0", new[] {"0"}}, {"1", new[] {"1"}}, {"2", new[] {"2"}},
            {"3", new[] {"3"}}, {"4", new[] {"4"}}, {"5", new[] {"5"}},
            {"6", new[] {"6"}}, {"7", new[] {"7"}}, {"8", new[] {"8"}},
            {"9", new[] {"9"}},
            {"a", new[] {"a"}}, {"b", new[] {"b"}}, {"c", new[] {"c"}},
            {"d", new[] {"d"}}, {"e", new[] {"e"}}, {"f", new[] {"f"}},
            {"g", new[] {"g"}}, {"h", new[] {"h"}}, {"i", new[] {"i"}},
            {"j", new[] {"j"}}, {"k", new[] {"k"}}, {"l", new[] {"l"}},
            {"m", new[] {"m"}}, {"n", new[] {"n"}}, {"o", new[] {"o"}},
            {"p", new[] {"p"}}, {"q", new[] {"q"}}, {"r", new[] {"r"}},
            {"s", new[] {"s"}}, {"t", new[] {"t"}}, {"u", new[] {"u"}},
            {"v", new[] {"v"}}, {"w", new[] {"w"}}, {"x", new[] {"x"}},
            {"y", new[] {"y"}}, {"z", new[] {"z"}},
            {"A", new[] {"A"}}, {"B", new[] {"B"}}, {"C", new[] {"C"}},
            {"D", new[] {"D"}}, {"E", new[] {"E"}}, {"F", new[] {"F"}},
            {"G", new[] {"G"}}, {"H", new[] {"H"}}, {"I", new[] {"I"}},
            {"J", new[] {"J"}}, {"K", new[] {"K"}}, {"L", new[] {"L"}},
            {"M", new[] {"M"}}, {"N", new[] {"N"}}, {"O", new[] {"O"}},
            {"P", new[] {"P"}}, {"Q", new[] {"Q"}}, {"R", new[] {"R"}},
            {"S", new[] {"S"}}, {"T", new[] {"T"}}, {"U", new[] {"U"}},
            {"V", new[] {"V"}}, {"W", new[] {"W"}}, {"X", new[] {"X"}},
            {"Y", new[] {"Y"}}, {"Z", new[] {"Z"}},
            {" ", new[] {" "}}, {"　", new[] {" "}}, {"\'", new[] {"\'"}},
            {"-", new[] {"-"}}, {",", new[] {","}}, {".", new[] {"."}},
            {";", new[] {";"}}, {":", new[] {":"}}, {"[", new[] {"["}},
            {"]", new[] {"]"}}, {"@", new[] {"@"}}, {"/", new[] {"/"}},
            {"_", new[] {"_"}}, {"!", new[] {"!"}}, {"！", new[] {"!"}},
            {"?", new[] {"?"}}, {"？", new[] {"?"}}
        };
    }
}