namespace PokemonDexx
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();

        public Form1()
        {
            InitializeComponent();
            LoadPokemonList();
        }

        private void LoadPokemonList()
        {
            pokemonDict["Pikachu"] = new Pikachu();
            pokemonDict["Snorlax"] = new Snorlax();
            pokemonDict["Luvdisc"] = new Luvdisc();
            pokemonDict["Swirlix"] = new Swirlix();
            pokemonDict["Unown"] = new Unown();
            pokemonDict["Diglett"] = new Diglett();

            displayPokemon(pokemonDict["Pikachu"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void displayPokemon(Pokemon pokemon)
        {
            lbName.Text = pokemon.getName();
            lbType.Text = pokemon.getType();
            lbHP.Text = pokemon.getHP().ToString();
            lbATK.Text = pokemon.getAttack().ToString();
            lbDEF.Text = pokemon.getDefense().ToString();
            lbSpl_ATK.Text = pokemon.getSpecialAttack().ToString();
            lbSpl_DEF.Text = pokemon.getSpecialDefense().ToString();
            lbSpeed.Text = pokemon.getSpeed().ToString();
            lbTotal.Text = pokemon.getTotal().ToString();
            lbHeight.Text = pokemon.getHeight().ToString() + " m";
            lbWeight.Text = pokemon.getWeight().ToString() + " kg";

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }

        }

        private void btnPikachu_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Pikachu"]);


        private void btnSnorlax_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Snorlax"]);


        private void btnDiglett_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Diglett"]);


        private void btnSwirlix_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Swirlix"]);


        private void btnLuvdisc_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Luvdisc"]);


        private void btnUnown_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Unown"]);

    }
}
