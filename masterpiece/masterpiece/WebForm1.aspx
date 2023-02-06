<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="masterpiece.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
              <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="styles.css" />
       <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>

  
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css"/>
    <link rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.theme.default.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.2.1/owl.carousel.js"></script>

        <link rel="stylesheet" href="homee.css" />

    <title></title>
    <style>


   


        * {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  font-family: sans-serif;
}

a {
  text-decoration: none;
  color: black;
  font-size: 1.2rem;
  font-weight: bold;
  text-transform: uppercase;

}
        .nav1 {
            display: flex;
            justify-content: space-between;
            align-items: center;
         margin:0;
            background-color: #20BBBD;
            opacity:.8;
              position: fixed;
              top:0;
 width:100%;
 z-index:2;
        
        }

.logo {
  font-size: 1rem;
  color: white;
  padding-left: 20px;
  
}

.hamburger {
  padding-right: 20px;
  cursor: pointer;
  color:white;
}

.hamburger .line {
  display: block;
  width: 40px;
  height: 5px;
  margin-bottom: 10px;
  background-color: white;
}

.nav__link {
  position: fixed;
  width: 100%;
  top: 5.8rem;
  left: 0px;
   background-color: #20BBBD;
   opacity:.8;
}

.nav__link a {
  display: block;
  text-align: center;
  padding: 10px 0;
}

.nav__link a:hover {
  background-color: lightcoral;
}

.hide {
  display: none;
}


@media screen and (min-width: 1150px) {
  .nav__link {
    display: block;
    position: static;
    width: auto;
    margin-right: 20px;
    background: none;
  }

  .nav__link a {
    display: inline-block;
    padding: 5px 20px;
  }

  .hamburger {
    display: none;
  }

}

/*try*/

/* Importing fonts from Google */
@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700;800;900&display=swap');

/* Reseting */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    /*  background: linear-gradient(to right, #101c81, #2a6ba3);
    min-height: 100vh;*/
}

.owl-carousel .owl-item {
    transition: all 0.3s ease-in-out;
}

    .owl-carousel .owl-item .card {
        padding: 30px;
        position: relative;
    }

.owl-carousel .owl-stage-outer {
    overflow-y: auto !important;
    padding-bottom: 40px;
}

.owl-carousel .owl-item img {
    height: 200px;
    object-fit: cover;
    border-radius: 6px;
}

.owl-carousel .owl-item .card .name {
    position: absolute;
    bottom: -20px;
    left: 33%;
    color: black;
    font-size: 1.1rem;
    font-weight: 600;
    background-color: #20BBBD;
    opacity: .8;
    padding: 0.3rem 0.4rem;
    border-radius: 5px;
    box-shadow: 2px 3px 15px #3c405a;
}

.owl-carousel .owl-item .card {
    opacity: 0.2;
    transform: scale3d(0.8, 0.8, 0.8);
    transition: all 0.3s ease-in-out;
}

.owl-carousel .owl-item.active.center .card {
    opacity: 1;
    transform: scale3d(1, 1, 1);
}

.owl-carousel .owl-dots {
    display: inline-block;
    width: 100%;
    text-align: center;
}

.owl-theme .owl-dots .owl-dot span {
    height: 20px;
    background: #2a6ba3 !important;
    border-radius: 2px !important;
    opacity: 0.8;
}

.owl-theme .owl-dots .owl-dot.active span,
.owl-theme .owl-dots .owl-dot:hover span {
    height: 13px;
    width: 13px;
    opacity: 1;
    transform: translateY(2px);
    background: #83b8e7 !important;
}

@media(min-width: 480.6px) and (max-width: 575.5px) {
    .owl-carousel .owl-item .card .name {
        left: 24%;
    }
}

@media(max-width: 360px) {
    .owl-carousel .owl-item .card .name {
        left: 30%;
    }
}

.owl-item .calling {
    position: relative;
}

.rating {
    position: absolute;
    top: 40px;
    left: 40px;
}

    .rating p {
        display: inline-block;
    }

.fa-star {
    color: goldenrod;
}

.name {
    font-size: 15px;
}

.txtabout .numb{
    color:#20BBBD;
    border:0.5px solid black;
    border-radius:7px;
    padding:2px 10px;
   box-shadow: -5px -9px 82px -10px rgba(0,0,0,0.75);
-webkit-box-shadow: -5px -9px 82px -10px rgba(0,0,0,0.75);
-moz-box-shadow: -5px -9px 82px -10px rgba(0,0,0,0.75);
  font-size:25px;
margin-right:10px;

}
.txtabout  .main{
    color:#20BBBD;
    font-size:20px;
    display:inline;
    font-size:25px;

}
.secondery{
    margin-left:50px;
}
.txtabout{
    margin-bottom:100px;
}

.about{
    display:flex;
    flex-wrap:wrap;
    justify-content:center;
    align-items:center;
    
}

.picture{
    margin-left:20px;
}
    </style>
</head>
<body onload=" myTimer();tim()">
    <form id="form1" runat="server">
        <div>
             <header>
              
      <nav class="nav1" id="navbar">
         
        <a href="/" class=""><img src="img/logo.png" width="80" alt="logo" style="padding:0px !important;margin-left:50px !important"/></a>

        <div class="hamburger">
          <span class="line"></span>
          <span class="line"></span>
          <span class="line"></span>
        </div>

        <div class="nav__link hide">
              <a href="#">home</a>
          <a href="#">about</a>
          <a href="#">contact</a>
          <a href="#">therapist list</a>
          <a href="#">psycologist list</a>
              <a href="#">log out</a>
              <a href="#"><i class="fa-solid fa-user"></i></a>
        </div>
      </nav>
    </header>
        </div>
        <div class="landing class1" id="slide">
            <div class="left">
                    <i class="fa-solid fa-chevron-right" id="rightt"></i>
                </div>
                <div style="color: white">
                    <p class="KNOWLEDGE" id="KNOWLEDGE"></p>
                    <p class="loyal" style="display: none">There is no friend as loyal as a book.</p>
                    <p class="reader" style="display: none">A reader lives a thousand lives before he dies.</p>


                </div>
                <div class="right">
                    <i class="fa-solid fa-chevron-left" id="leftt"></i>
                </div>
            <div class="onlcon">
            <p ><span class="online">online</span><span class="con">consultion</span></p></div>
            <div class="started">

                <asp:Button ID="started" runat="server" Text="Get Started" />
                <div class="calling">
                    <p class="priv">online private session</p>

                    <div class="icon">
                     <a href="#">   <i class="fa-solid fa-video"></i><span id="video"> video</span></a>

                  <a href="#">  <i class="fa-solid fa-microphone"></i><span id="Audio"> Audio</span></a>
                        </div>

                </div>
            </div>
        </div>



        <div class="explore ">
            <div class="first"><p>explore our website and learn more about Services</p></div>
            <div class="sec"><p> and resources we offer, and we look forward to supporting you on your journey to better mental health and well-being,we are here to help you.</p></div>


        </div>
        <div class="kind">
            <div class="box1">
                <img src="img/m1.png" width="200" alt="covering" />
                <h2>Individual therapy</h2>
<p>form of psychological treatment that involves working one-on-one with a therapist to address personal challenges.
    you will have the opportunity to discuss your thoughts, feelings, and experiences in a safe and confidential setting.</p>
                <asp:Button ID="start" runat="server" Text="Get Started" CssClass="start" />
            </div>

                <div class="box1">
                <img src="img/m2.png" width="200" alt="covering" style="margin-top:28px"/>
                <h2 style="margin-top:-20px;">Family therapy</h2>
<p>type of therapy that focuses on the dynamics and relationships within a family unit.
  It can be useful for families dealing with issues such as parenting challenges, sibling rivalry,increased feelings of connectedness and satisfaction within the family and family dynamics.</p>
                <asp:Button ID="Button1" runat="server" Text="Get Started" CssClass="start"  />
            </div>
                <div class="box1">
                <img src="img/m3.png" width="200" alt="covering" />
                <h2>Couple therapy</h2>
<p>It can be helpful for couples who are experiencing conflicts, communication problems, or changes in their relationship.
  Through a variety of techniques such as communication exercises, problem-solving activities, couple psychological therapy can help couples improve their relationship and strengthen their bond.</p>
                <asp:Button ID="Button2" runat="server" Text="Get Started" CssClass="start"  />
            </div>
                <div class="box1">
                <img src="img/m4.png" width="200" alt="covering" />
                <h2>Conselling therapy</h2>
<p>It is often a short-term treatment that focuses on specific problems and aims to provide the individual with coping strategies and skills to improve their overall mental well-being. A trained counselor or psychologist works with the individual to identify and address any underlying issues or patterns of behavior that may be contributing to their difficulties.
   .</p>
                <asp:Button ID="Button3" runat="server" Text="Get Started" CssClass="start"  />
            </div>

        </div>

        
        <div class="explore ">
            <div class="first"><p>we are proud to connect you with a team of </p></div>
            <div class="sec"><p>highly qualified and experienced  therapists who are dedicated to helping people reach their full potential. Our therapists are skilled in a variety of areas, including Some common forms of psychotherapy include:Interpersonal therapy (IPT),Dialectical behavior therapy (DBT) and Humanistic therapies..etc</p></div>


        </div>


        <%--try--%>
    <div class="owl-carousel owl-theme mt-5">
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                    <img src="img/dr.png"
                        alt=""/>
                    <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                
                </div>
                <div class="testimonial mt-4 mb-2">
             Shatha Abdeljaleel holds a Bachelor's degree in Psychological Counseling and Mental Health from the University of Jordan, and she completed her Master's degree in the same field from the Arab University of Jordan. 
                </div>
                <div class="name" style="font-size:15px">
                   DR-Shatha Abd AL-Jaleel
                </div>
            </div>
        </div>
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                    <img src="img/dr2.png"
                        alt=""/>
                        <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                </div>
                <div class="testimonial mt-4 mb-2">
               Dr. Omar Ali Alqam is a psychiatric and addiction specialist who holds a Jordanian board in psychiatry and is a member of the Jordanian Psychiatric Association. 
                    
                </div>
                <div class="name" style="font-size:15px">
                 DR-Omar ALI-alqam
                </div>
            </div>
        </div>
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                   <img src="img/dr3.png"
                        alt=""/>
                        <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                </div>
                <div class="testimonial mt-4 mb-2">
Dr. Ahmed Al-Dabaas is a psychiatric and addiction specialist who received his medical degree from Mutah University and was one of the founders of IFMSA-Jo/Mutah,
                    and later a member of the supervisory board.
                </div>
                <div class="name">
                  DR-Ahmad AL-Dabbas
                </div>
            </div>
        </div>
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                   <img src="img/dr6.png"
                        alt="" />
                        <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                </div>
                <div class="testimonial mt-4 mb-2">
                Dr. Maan Al-Abki is a psychiatric and addiction specialist who holds both the Jordanian and the Arab Board in Psychiatry.
               
                </div>
                <div class="name">
                 DR-maen Al-abki
                </div>
            </div>
        </div>
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                   <img src="img/dralaa.png"
                        alt="" />
                        <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                </div>
                <div class="testimonial mt-4 mb-2">
                   Dr. Alaa Mohammed Zaid is a specialist in psychiatric disorders and addiction, holding a Bachelor of Medicine and Surgery degree from Hadhramout University of Science and Technology in Yemen in 2011. 
             .
                </div>
                <div class="name">
                  Dr. Alaa Mohammed Zaid 
                </div>
            </div>
        </div>
        <div class="owl-item">
            <div class="card">
                <div class="img-card">
                    <img src="img/drhiba.png"
                        alt="" />
                        <div class="rating">

                            <i class="fa-sharp fa-solid fa-star"></i>
                        <p>4.85</p>

                    </div>
                </div>
                <div class="testimonial mt-4 mb-2">
                    Hiba Al-Shakhshir is a psychological therapist who holds a Master's degree in Mental Health from Queen Mary University in London, and a Bachelor's degree in Psychology from the American 
                    University in Beirut..
                </div>
                <div class="name">
                 DR-Hiba Al-Shakhshir
                </div>
            </div>
        </div>
    </div>


        <%--try--%>


        
        <%--about--%>
        <div class="explore ">
            <div class="first"><p>How "Finding peace" Works?</p></div>
           
        </div>


        <div class="about ">
            <div class="word ">

<div class="txtabout ">
    <span class="numb">1</span><p class="main">create an account and fill out a confidential intake</p>
    <p class="secondery">form with information about their mental health history and current concerns.</p>
</div>
<div class="txtabout ">
    <span class="numb">2</span><p class="main">Browse through a list of qualified psychologists</p>
    <p class="secondery">read their profiles and reviews, and select one that aligns with their needs and preferences.</p>
</div>
            <div class="txtabout ">
    <span class="numb">3</span><p class="main">schedule and pay for sessions through the website</p>
    <p class="secondery">During the sessions, users can communicate with their psychologist through a secure video..</p>
</div>

                  <img src="img/step.png"  width="450"/>
                </div>
<div class="picture">
    <img src="img/lab.png"  width="500" height="500"/>
</div>
        </div>

        <%--about--%>
    </form>
    <script>
        $(document).ready(function () {
            var silder = $(".owl-carousel");
            silder.owlCarousel({
                autoplay: true,
                autoplayTimeout: 3000,
                autoplayHoverPause: false,
                items: 1,
                stagePadding: 20,
                center: true,
                nav: false,
                margin: 50,
                dots: true,
                loop: true,
                responsive: {
                    0: { items: 1 },
                    480: { items: 2 },
                    575: { items: 2 },
                    768: { items: 2 },
                    991: { items: 3 },
                    1200: { items: 4 }
                }
            });
        });


    </script>
    <script src="home.js"></script>
</body>
</html>
