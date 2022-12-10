import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'
import WebLogin from '../components/WebLogin.vue'
import WebHome from "../components/WebHome.vue";

Vue.use(VueRouter)

const routes = [
  {
    path: '/home',
    name: 'home2',
    component: HomeView
  },
  {
    path: '/',
    name: 'home1',
    component: WebHome
  },
  {
    path: '/login',
    name: 'login',
    component: WebLogin
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
