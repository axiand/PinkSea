<script setup lang="ts">
  import { useRouter } from 'vue-router'

  const router = useRouter();
  const navi = () => {
    router.push("/af2025");
  };
</script>

<template>
  <div class="af-banner">
    <div>
      <p><b>NEW</b> from PinkSea</p>
      <p>A brand new way to create and share images.</p>
    </div>
    <div>
      <button v-on:click.prevent="navi">Check it out >></button>
    </div>
  </div>
</template>

<style scoped>
  .af-banner {
    padding: 0px 1.15em;
    display: flex;
    align-items: center;
    flex-direction: row;
    justify-content: space-between;
    border: solid #FFB6C1 1px;
    border-left: none;
    border-right: none;
    margin-top: 0.15em;
    background-image: linear-gradient(20deg, #fbe9ec,#ff7f97);
  }

  .af-banner > div > p {
    margin: 0.25em 0px;
  }
</style>
