using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Card_Random.Data.Models
{
    public class Card
    {
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string @object { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string idCard { get; set; }

        [JsonProperty("oracle_id", NullValueHandling = NullValueHandling.Ignore)]
        public string oracle_id { get; set; }

        [JsonProperty("multiverse_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> multiverse_ids { get; set; }

        [JsonProperty("mtgo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? mtgo_id { get; set; }

        [JsonProperty("mtgo_foil_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? mtgo_foil_id { get; set; }

        [JsonProperty("tcgplayer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? tcgplayer_id { get; set; }

        [JsonProperty("cardmarket_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? cardmarket_id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string nameCard { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string lang { get; set; }

        [JsonProperty("released_at", NullValueHandling = NullValueHandling.Ignore)]
        public string released_at { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string uriCard { get; set; }

        [JsonProperty("scryfall_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string scryfall_uri { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public string layout { get; set; }

        [JsonProperty("highres_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? highres_image { get; set; }

        [JsonProperty("image_status", NullValueHandling = NullValueHandling.Ignore)]
        public string image_status { get; set; }

        [JsonProperty("image_uris", NullValueHandling = NullValueHandling.Ignore)]
        public ImageUris image_uris { get; set; }

        [JsonProperty("mana_cost", NullValueHandling = NullValueHandling.Ignore)]
        public string mana_cost { get; set; }

        [JsonProperty("cmc", NullValueHandling = NullValueHandling.Ignore)]
        public double? cmc { get; set; }

        [JsonProperty("type_line", NullValueHandling = NullValueHandling.Ignore)]
        public string type_line { get; set; }

        [JsonProperty("oracle_text", NullValueHandling = NullValueHandling.Ignore)]
        public string oracle_text { get; set; }

        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public string power { get; set; }

        [JsonProperty("toughness", NullValueHandling = NullValueHandling.Ignore)]
        public string toughness { get; set; }

        [JsonProperty("colors", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> colors { get; set; }

        [JsonProperty("color_identity", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> color_identity { get; set; }

        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> keywords { get; set; }

        [JsonProperty("legalities", NullValueHandling = NullValueHandling.Ignore)]
        public Legalities legalities { get; set; }

        [JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> games { get; set; }

        [JsonProperty("reserved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? reserved { get; set; }

        [JsonProperty("foil", NullValueHandling = NullValueHandling.Ignore)]
        public bool? foil { get; set; }

        [JsonProperty("nonfoil", NullValueHandling = NullValueHandling.Ignore)]
        public bool? nonfoil { get; set; }

        [JsonProperty("finishes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> finishes { get; set; }

        [JsonProperty("oversized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? oversized { get; set; }

        [JsonProperty("promo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? promo { get; set; }

        [JsonProperty("reprint", NullValueHandling = NullValueHandling.Ignore)]
        public bool? reprint { get; set; }

        [JsonProperty("variation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? variation { get; set; }

        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string set_id { get; set; }

        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        public string set { get; set; }

        [JsonProperty("set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string set_name { get; set; }

        [JsonProperty("set_type", NullValueHandling = NullValueHandling.Ignore)]
        public string set_type { get; set; }

        [JsonProperty("set_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string set_uri { get; set; }

        [JsonProperty("set_search_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string set_search_uri { get; set; }

        [JsonProperty("scryfall_set_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string scryfall_set_uri { get; set; }

        [JsonProperty("rulings_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string rulings_uri { get; set; }

        [JsonProperty("prints_search_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string prints_search_uri { get; set; }

        [JsonProperty("collector_number", NullValueHandling = NullValueHandling.Ignore)]
        public string collector_number { get; set; }

        [JsonProperty("digital", NullValueHandling = NullValueHandling.Ignore)]
        public bool? digital { get; set; }

        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public string rarity { get; set; }

        [JsonProperty("flavor_text", NullValueHandling = NullValueHandling.Ignore)]
        public string flavor_text { get; set; }

        [JsonProperty("card_back_id", NullValueHandling = NullValueHandling.Ignore)]
        public string card_back_id { get; set; }

        [JsonProperty("artist", NullValueHandling = NullValueHandling.Ignore)]
        public string artist { get; set; }

        [JsonProperty("artist_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> artist_ids { get; set; }

        [JsonProperty("illustration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string illustration_id { get; set; }

        [JsonProperty("border_color", NullValueHandling = NullValueHandling.Ignore)]
        public string border_color { get; set; }

        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public string frame { get; set; }

        [JsonProperty("full_art", NullValueHandling = NullValueHandling.Ignore)]
        public bool? full_art { get; set; }

        [JsonProperty("textless", NullValueHandling = NullValueHandling.Ignore)]
        public bool? textless { get; set; }

        [JsonProperty("booster", NullValueHandling = NullValueHandling.Ignore)]
        public bool? booster { get; set; }

        [JsonProperty("story_spotlight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? story_spotlight { get; set; }

        [JsonProperty("edhrec_rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? edhrec_rank { get; set; }

        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public Prices prices { get; set; }

        [JsonProperty("related_uris", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedUris related_uris { get; set; }

        [JsonProperty("purchase_uris", NullValueHandling = NullValueHandling.Ignore)]
        public PurchaseUris purchase_uris { get; set; }
    }

    public class PurchaseUris
    {
        [JsonProperty("tcgplayer", NullValueHandling = NullValueHandling.Ignore)]
        public string tcgplayer { get; set; }

        [JsonProperty("cardmarket", NullValueHandling = NullValueHandling.Ignore)]
        public string cardmarket { get; set; }

        [JsonProperty("cardhoarder", NullValueHandling = NullValueHandling.Ignore)]
        public string cardhoarder { get; set; }
    }

    public class RelatedUris
    {
        [JsonProperty("gatherer", NullValueHandling = NullValueHandling.Ignore)]
        public string gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles", NullValueHandling = NullValueHandling.Ignore)]
        public string tcgplayer_infinite_articles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks", NullValueHandling = NullValueHandling.Ignore)]
        public string tcgplayer_infinite_decks { get; set; }

        [JsonProperty("edhrec", NullValueHandling = NullValueHandling.Ignore)]
        public string edhrec { get; set; }
    }

    public class Prices
    {
        [JsonProperty("usd", NullValueHandling = NullValueHandling.Ignore)]
        public string usd { get; set; }

        [JsonProperty("usd_foil", NullValueHandling = NullValueHandling.Ignore)]
        public string usd_foil { get; set; }

        [JsonProperty("usd_etched", NullValueHandling = NullValueHandling.Ignore)]
        public object usd_etched { get; set; }

        [JsonProperty("eur", NullValueHandling = NullValueHandling.Ignore)]
        public string eur { get; set; }

        [JsonProperty("eur_foil", NullValueHandling = NullValueHandling.Ignore)]
        public string eur_foil { get; set; }

        [JsonProperty("tix", NullValueHandling = NullValueHandling.Ignore)]
        public string tix { get; set; }
    }

    public class ImageUris
    {
        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public string small { get; set; }

        [JsonProperty("normal", NullValueHandling = NullValueHandling.Ignore)]
        public string normal { get; set; }

        [JsonProperty("large", NullValueHandling = NullValueHandling.Ignore)]
        public string large { get; set; }

        [JsonProperty("png", NullValueHandling = NullValueHandling.Ignore)]
        public string png { get; set; }

        [JsonProperty("art_crop", NullValueHandling = NullValueHandling.Ignore)]
        public string art_crop { get; set; }

        [JsonProperty("border_crop", NullValueHandling = NullValueHandling.Ignore)]
        public string border_crop { get; set; }
    }

    public class Legalities
    {
        [JsonProperty("standard", NullValueHandling = NullValueHandling.Ignore)]
        public string standard { get; set; }

        [JsonProperty("future", NullValueHandling = NullValueHandling.Ignore)]
        public string future { get; set; }

        [JsonProperty("historic", NullValueHandling = NullValueHandling.Ignore)]
        public string historic { get; set; }

        [JsonProperty("gladiator", NullValueHandling = NullValueHandling.Ignore)]
        public string gladiator { get; set; }

        [JsonProperty("pioneer", NullValueHandling = NullValueHandling.Ignore)]
        public string pioneer { get; set; }

        [JsonProperty("explorer", NullValueHandling = NullValueHandling.Ignore)]
        public string explorer { get; set; }

        [JsonProperty("modern", NullValueHandling = NullValueHandling.Ignore)]
        public string modern { get; set; }

        [JsonProperty("legacy", NullValueHandling = NullValueHandling.Ignore)]
        public string legacy { get; set; }

        [JsonProperty("pauper", NullValueHandling = NullValueHandling.Ignore)]
        public string pauper { get; set; }

        [JsonProperty("vintage", NullValueHandling = NullValueHandling.Ignore)]
        public string vintage { get; set; }

        [JsonProperty("penny", NullValueHandling = NullValueHandling.Ignore)]
        public string penny { get; set; }

        [JsonProperty("commander", NullValueHandling = NullValueHandling.Ignore)]
        public string commander { get; set; }

        [JsonProperty("brawl", NullValueHandling = NullValueHandling.Ignore)]
        public string brawl { get; set; }

        [JsonProperty("historicbrawl", NullValueHandling = NullValueHandling.Ignore)]
        public string historicbrawl { get; set; }

        [JsonProperty("alchemy", NullValueHandling = NullValueHandling.Ignore)]
        public string alchemy { get; set; }

        [JsonProperty("paupercommander", NullValueHandling = NullValueHandling.Ignore)]
        public string paupercommander { get; set; }

        [JsonProperty("duel", NullValueHandling = NullValueHandling.Ignore)]
        public string duel { get; set; }

        [JsonProperty("oldschool", NullValueHandling = NullValueHandling.Ignore)]
        public string oldschool { get; set; }

        [JsonProperty("premodern", NullValueHandling = NullValueHandling.Ignore)]
        public string premodern { get; set; }
    }
}
