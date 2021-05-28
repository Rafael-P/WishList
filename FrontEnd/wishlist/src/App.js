import { Component } from "react";
import "./App.css";
import imgLogo from "./assets/img/Wish List.svg";
import imgBanner from "./assets/img/Banner.png";
import imgGenio from "./assets/img/will.png";
import imgMen from "./assets/img/men.svg";

class WishList extends Component {
   render() {
      const styleInstagram = {
         fontSize: "54px",
         color: "#B07AEA",
      };

      const styleLinkedin = {
         fontSize: "54px",
         color: "#B07AEA",
      };

      const styleFacebook = {
         fontSize: "54px",
         color: "#B07AEA",
      };

      return (
         <div>
            <header>
               <div className="top">
                  <div className="icons_head">
                     <a href="">
                        <i
                           className="fab fa-instagram"
                           style={styleInstagram}
                        ></i>
                     </a>

                     <a href="">
                        <i
                           className="fab fa-linkedin"
                           style={styleLinkedin}
                        ></i>
                     </a>

                     <a href="">
                        <i
                           className="fab fa-facebook-square"
                           style={styleFacebook}
                        ></i>
                     </a>
                  </div>

                  <div className="logo">
                     <a href="#">
                        <img src={imgLogo} alt="Logo WishList" />
                     </a>
                  </div>

                  <div className="logon">
                     <a href="#">Cadastrar-se</a>
                     <p>|</p>
                     <a href="#">Login</a>
                  </div>
               </div>

               <div className="line1"></div>

               <div className="navbar">
                  <div className="menu">
                     <a href="#">Início</a>
                     <a href="#">Desejos</a>
                     <a href="#">Contato</a>
                  </div>

                  <div id="divBusca">
                     <input
                        className="camp"
                        type="search"
                        placeholder=" &#xF002; Pesquisar..."
                        value=""
                        tabindex="1"
                        autocomplete="off"
                     />
                  </div>
               </div>
            </header>

            <main>
               <section className="banner">
                  <img
                     src={imgBanner}
                     alt="Banner de um astronauta flutuando na orbita da terra"
                  />
               </section>

               <div className="esquerda">
                  <section className="sobre margem">
                     <h1>O QUE É DESEJO?</h1>
                     <div className="line2"></div>
                     <div className="pessoa margem">
                        <img src={imgGenio} alt="Will Smith Gênio" />
                        <h2>Will Smith Gênio</h2>
                     </div>
                     <div className="txt margem">
                        <p>
                           Em filosofia, o desejo é uma tensão em direção a um
                           fim que é considerado, pela pessoa que deseja, uma
                           fonte de satisfação. É uma tendência algumas vezes
                           consciente, outras vezes inconsciente ou reprimida.
                           Quando consciente, o desejo é uma atitude mental que
                           acompanha a representação do fim esperado. Enquanto
                           elemento apetitivo, o desejo se distingue da
                           necessidade fisiológica ou psicológica que o
                           acompanha por ser o elemento afetivo do respectivo
                           estado fisiológico ou psicológico.
                           <br />
                           <br />
                           Tradicionalmente, o desejo pressupõe carência,
                           indigência. Um ser que não carecesse de nada não
                           desejaria nada, seria um ser perfeito, um deus. Por
                           isso, Platão e os filósofos cristãos tomam o desejo
                           como uma característica de seres finitos e
                           imperfeitos. Os filósofos viram o Bem como o objeto
                           do desejo. Atualmente, isso é questionado.
                        </p>
                     </div>
                  </section>
               </div>

               <section className="desejos">
                  <h1>Desejos</h1>
                  <div className="conteudo">
                     <div className="dados">
                        <div className="info">
                           <p>Nome</p>
                           
                           <input
                              className="campos"
                              type="text"
                              placeholder="Ex. Junior"
                           />

                           <p>Título do Desejo</p>

                           <input
                              className="campos"
                              type="text"
                              placeholder="Ex. Quero uma Savero"
                           />

                           <p>Descrição</p>

                           <input
                              className="campos"
                              type="text"
                              placeholder="Ex. Com Paredão"
                           />

                           <input
                              className="btn"
                              type="submit"
                              value="Adicionar"
                           />
                        </div>
                        <img
                           src={imgMen}
                           alt="Homem sentado com um Tablet"
                        />
                     </div>
                     <div className="line3"></div>

                     <div className="tabela">
                        <h2>Título</h2>
                        <h3>Nome</h3>
                        <p>Descrição</p>
                     </div>
                  </div>
               </section>
            </main>
         </div>
      );
   }
}

function App() {
   return <WishList />;
}

export default App;
