<template>
  <div id="app">
      <img src="https://unri.ac.id/wp-content/uploads/2021/03/logo-unri2-800x116.png" height="75" width="520">
    <v-app>
      <web-toolbar></web-toolbar>
      <router-view/>
      <web-footer></web-footer>
    </v-app>
    
  </div>
</template>

<script>
import WebFooter from './components/WebFooter'
import WebToolbar from './components/WebToolbar'
import router from './router';

export default {
  name: 'App',
  components: { WebFooter, WebToolbar, router }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  margin: auto;
}
</style>