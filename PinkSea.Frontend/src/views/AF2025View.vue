<script setup lang="ts">
/*
  Apologies in advance for the mess in this file.
  I literally got the idea and wrote this whole thing the day of, proper conventions be damned.
*/

import PanelLayout from '@/layouts/PanelLayout.vue'
import { useTemplateRef } from 'vue';

const af = useTemplateRef<HTMLElement>("af-body");

const revealFaq = (id) => {
  af.value!.querySelector("#" + id)?.classList.toggle("faq-entry-hidden");
}

const surprise = () => {
  af.value!.querySelector("#surprise")?.classList.toggle("af-hide");
}

</script>

<template>
  <PanelLayout>
      <div class="head">
        <h1>Let's face it.</h1>
        <p>Art is just too time-consuming. <i>Creativity</i> is too time-consuming. With each finished piece, your hands ache a little more. It's all such a chore!</p>
        <h1>We have a solution.</h1>
        <p>Introducting Auto-Oekaki from PinkSea. You'll never run out of art again.</p>
      </div>

      <div class="af-style-tweaks" ref="af-body">
        <h1>THE ASSISTANT</h1>
        <p>The PinkSea Assistant is the culmination of years of effort from society's finest engineeers. Trained on gigabytes of pop culture listicles, angry internet comments, professionally curated scrawlings from public restrooms around our scenic headquarters, and private messages, the Assistant is the perfect friend to guide you through learning the incredible skill that is art.</p>
        <p>Our team of testers has already certified that the Assistant is able to strike up a friendly conversation and happily teach the user the ins and outs of digital artistry, even providing helpful tips and original ideas of its own. Just don't let it go off-topic. We know and we're trying to iron out the ranting.</p>
        <p>Here's a sampling of helpful feedback from the Assistant:</p>
        <p><b>- "Hey, I think you forgot some shading around that character's hands."</b></p>
        <p><b>- "Hmm, the distance between the eyes looks a little odd. Try the Move tool."</b></p>
        <p><b>- "If it's not too much to ask, could you put more detail on her feet? Please?"</b></p>
        <h1>FULLY AUTOMATED ART CREATOR</h1>
        <p>BUT WAIT - THERE'S MORE! Time to bring out the big guns. We know that some artists don't have the time in their day to dedicate to distractions from the artistic process, like drawing, so we've invested additional resources in the next evolution in your smörgåsbord of creative tooling: outsourcing the work to a machine.</p>
        <p>The usage is as simple as it gets, anyone who can pour water out of a boot can do it: simply type in a prompt, and let our mainframes dream up an image for you. And before you ask, and we know the more <i>eccentric</i> of you in the audience will ask - yes, this thing has <i>no limits</i>. You can use it for defamation. Especially defamation.</p>
        <p>Create whatever tickles your fancy and save it in our cloud storage offering for your eyes and the intern with read access to the data bucket's eyes only.</p>
        <p>We feel proud saying that our art generator represents the bleeding edge of mass-produced art-like products. Check out the "Affirmations" button afterwards to have a counseling session with our assistant, who will reaffirm your position as an artist. Don't let 'em get you down, tiger. You're not just a prompter. You're an <i>artist.</i></p>
        <h1>THE FAQ</h1>
        <p>We know you have questions. We know you're interrogating us in your mind. With help from our Assistant, we've devised a list of common questions you might ask. So ask away. And if your question is not in the list, then we don't know the answer ourselves. Click the entries to reveal them.</p>
        <div class="faq-entry faq-entry-hidden" id="entry-datacenter" v-on:click.prevent="revealFaq('entry-datacenter')">
          <b>I heard you invested in building a massive datacenter just for this. Why?</b>
          <div>
            <p>We needed lots of storage space to store all the amazing photos our beloved users generate using the Art Creator offering. Most of this stuff will never be looked at after the first week of existence, but just in case, we need to store it indefinitely.</p>
            <p>Also, we never really delete anything. We only really provide the option to "delete" (hahaha) your account to keep regulators happy.</p>
          </div>
        </div>
        <div class="faq-entry faq-entry-hidden" id="entry-privacy" v-on:click.prevent="revealFaq('entry-privacy')">
          <b>What steps are you taking to protect my privacy when I use these tools?</b>
          <div>
            <p>The clause in the Privacy Policy about manual reviews may cause controversy, but rest assured that PinkSea respects your privacy, and that the conversations between you and the Assistant, as well as images generated using the Art Creator stay private between you, our trust and safety team, our machine learning scientists, our datacenter engineers, our founder, and our Partners, away from prying eyes.</p>
          </div>
        </div>
        <div class="faq-entry faq-entry-hidden" id="entry-compensation" v-on:click.prevent="revealFaq('entry-compensation')">
          <b>Do you compensate artists whose work was used in training?</b>
          <div>
            <p>Let's set it straight: no. Never have, never will. Hell, if anything, they should be compensating <i>us</i> for those workers we paid 12 cents an hour to label the images we scraped from them.</p>
          </div>
        </div>
        <div class="faq-entry faq-entry-hidden" id="entry-optout" v-on:click.prevent="revealFaq('entry-optout')">
          <b>How do I opt out from training?</b>
          <div>
            <p>If you're an artist: Check if the platform you're using has a no training check box of some kind. We can't promise anything, but we'll probably like respect it or something.</p>
            <p>If you're a system administrator: play whack-a-mole with our user agents and scraper IP addresses and let's see who lasts longer. And quit emailing us about robots.txt, we know, we're impersonating a browser version from 2008 for a reason.</p>
          </div>
        </div>
        <div class="faq-entry faq-entry-hidden" id="entry-dataset" v-on:click.prevent="revealFaq('entry-dataset')">
          <b>I heard your Assistant and Art Creator has some issues with cultural insensitivity. What's going on with that?</b>
          <div>
            <p>TODO come up with something here before pushing this page. it can be absolutely anything just make it sound nice. we cant afford another pr disaster like last time ~cto</p>
          </div>
        </div>
        <h1>TRY IT NOW!</h1>
        <p>Yeah, that's right. We're opening this up to the public, letting the masses have a taste of the impeccable skill displayed by the Art Creator. Just fill out the short form below to gain access and wait for the link to appear in your inbox.</p>
        <div class="af-prompt-area">
          <div>
            <p><b>Full Name</b></p>
            <input placeholder="First Name">
            <input placeholder="Last Name">
          </div>
          <div>
            <p><b>E-Mail</b></p>
            <input placeholder="E-Mail address">
          </div>
          <div>
            <p><b>Reasoning</b></p>
            <textarea placeholder="Please explain why you're worthy of access. Your response will be judged by the Assistant."></textarea>
          </div>
          <div>
            <p><b>Credit Card</b></p>
            <input placeholder="012345">
            <input class="short-textbox" placeholder="01/25">
            <input class="short-textbox" placeholder="123">
          </div>
          <div>
            <p><b>Phone Number</b></p>
            <input placeholder="+123 whatever">
          </div>
          <div>
            <p><b>Date of birth</b></p>
            <input type="date">
          </div>
          <div>
            <p><b>Image of yourself holding up a piece of paper with the words "I love PinkSea Assistant!" written on it. You consent to your upload being used in our marketing material.</b></p>
            <input type="file">
          </div>
          <div>
            <p><b>Blood type</b></p>
            <input placeholder="A">
          </div>
          <div>
            <p><b>Favourite food</b></p>
            <input placeholder="?">
          </div>
          <div>
            <p><b>In-depth analysis and deconstruction of the themes featured in a book of your choosing, minimum 2000 words</b></p>
          </div>
          <div>
            <textarea placeholder="Submissions will be checked for plagiarism."></textarea>
          </div>
          <div>
            <p><b>If an AI took over the world, would you cooperate with it in its mission to take out humanity?</b></p>
            <input type="checkbox">
          </div>
          <div>
            <p><b>Would you like to sign up for our newsletter? (required)</b></p>
            <input type="checkbox">
          </div>
          <div>
            <p><b>Would you like to sign up for our marketing emails? (required)</b></p>
            <input type="checkbox">
          </div>
          <div>
            <p><b>Would you like to sign up for our marketing phone calls? (required)</b></p>
            <input type="checkbox">
          </div>
          <div>
            <p><b>Check this box to affirm that you sign your rights away and that PinkSea accepts no liability for any events that occur during your use of our services. (required)</b></p>
            <input type="checkbox">
          </div>
          <div>
            <p><b>I agree to the Terms of Service and Privacy Policy.</b></p>
            <input type="checkbox">
          </div>
        </div>
        <div class="af-surprise af-hide" id="surprise">
          <p><b>Happy April Fools from PinkSea!</b></p>
          <p><b>Lovingly written by someone with too much time on their hands.</b></p>
        </div>
        <button v-on:click.prevent="surprise">Request access</button>
      </div>
  </PanelLayout>
</template>

<style scoped>
  .af-style-tweaks {
    margin: 0px 2em;
  }

  .af-style-tweaks > h1::before {
    content: "★";
    color: #FFB6C1;
    margin-right: 4px;
  }

  .af-style-tweaks > h1 {
    border-bottom: solid #FFB6C1 1px;
    font-size: 14pt;
    font-weight: bold;
  }

  .af-prompt-area > div {
    display: flex;
    flex-direction: row;
    align-items: center;
  }

  .af-prompt-area > div > p {
    margin-right: 0.25em;
  }

  .af-prompt-area > input {
    width: 8em;
    padding: 0.25em;
  }

  .af-style-tweaks > button {
    margin-bottom: 5em;
  }

  .af-hide {
    height: 0px;
    transform: scaleY(0) !important;
  }

  .af-surprise {
    width: 100%;
    text-align: center;
    border: solid #e7465e 1px;
    transform: scaleY(1);
    transition: transform 0.3s;
  }

  .short-textbox {
    width: 3em;
  }

  .af-prompt-area > div > textarea {
    width: 25em;
    resize: none;
  }

  .af-blank-box {
    height: 256px;
    width: 256px;
    border: solid #FFB6C1 1px;
    margin-bottom: 2em;
  }

  .faq-entry {
    border: solid #FFB6C1 1px;
    border-left: none;
    border-right: none;
    padding: 0.15em 0px;
  }

  .faq-entry:hover {
    background-color: rgba(255, 6, 130, 0.08);
  }

  .faq-entry > div > p {
    margin: 0.15em 0px;
    margin-left: 0.38em;
  }

  .faq-entry-hidden {
    cursor: pointer;
  }

  .faq-entry-hidden>div {
    display: none;
  }

  .head {
    text-align: center;
    padding: 1em 0px;
    border-bottom: solid #FFB6C1 1px;
    background-image: linear-gradient(20deg, #fbe9fa,#ffc2cd);
  }

  .head > h1 {
    font-size: 24pt;
  }

  .head > p {
    font-size: 14pt;
  }
</style>
