<template>
        <v-toolbar class="flex-grow-0" color="green darken-4" dark>
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
            <router-link style="text-decoration: none; color: inherit;" to='/'>
                <v-btn text href="WebHome.vue">Home</v-btn>
            </router-link>
            <v-btn text>Profile</v-btn>
            <v-btn text>Unit/Lembaga</v-btn>
            <v-btn text>Akademik</v-btn>
            <v-btn text>Dokumen</v-btn>
            <v-btn text>Gallery</v-btn>
            <v-btn text>Peta</v-btn>
            <v-btn text>Video Profil</v-btn>
            <router-link style="text-decoration: none; color: inherit;" to='/login'>
                <v-btn text href="WebLogin.vue">Kontak</v-btn>
            </router-link>
        <div class="hidden-sm-and-down">
            <v-navigation-drawer
                v-model="drawer"
                absolute
                temporary
                height="1000px">
                <v-list class="px-1">
                    <v-list-item-avatar>
                      <v-img src="https://randomuser.me/api/portraits/men/85.jpg"></v-img>
                    </v-list-item-avatar>
                
                    <v-list-item-title>John Leider</v-list-item-title>
                </v-list>
            
                <v-list>
                    <v-divider></v-divider>
                
                    <v-list-item
                        v-for="item in items"
                        :key="item.title"
                        link>
                        <v-list-item-icon>
                            <v-icon>{{ item.icon }}</v-icon>
                        </v-list-item-icon>
                    
                        <v-list-item-content>
                            <v-list-item-title>{{ item.title }}</v-list-item-title>
                        </v-list-item-content>
                    </v-list-item>
                </v-list>
            </v-navigation-drawer>
            </div>
        </v-toolbar>

</template>

<script>
    export default {
        data () {
            return {
                drawer: null,
                items: [
                    { title: 'Home', icon: 'dashboard' },
                    { title: 'About', icon: 'question_answer' }
                ]
            }
        }
    }
</script>

