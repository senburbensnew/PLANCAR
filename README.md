# PLANCAR

## Objectif
Centraliser la gestion du parc automobile des différentes entités de l’État.

## Fonctionnalités
Le système de gestion de parc automobile **PLANCAR** permet à une entité centrale de gérer les automobiles d’une institution. Il comprend trois modules principaux :

### 1. Module d’administration
- Gestion des véhicules et des institutions ayant accès au système.
- Traitement des formulaires de livraison et de réception des véhicules utilisés.
- Enregistrement de l’état des véhicules lors de leur réception et livraison.

### 2. Module de gestion des demandes d’utilisation
- Consultation des véhicules disponibles par les institutions connectées au système.
- Formulation et gestion des demandes d’utilisation.
- Notification par email pour le suivi des demandes.
- Validation automatique des demandes si aucun conflit n’est constaté (dates d’utilisation ou limites de service).
- Règles des demandes :
  - Formulées au moins 10 jours avant la date d’utilisation.
  - Non permises pour les véhicules en cours d’utilisation ou déjà sollicités.

### 3. Module de gestion des alertes
- Envoi de notifications par email au responsable de la logistique des institutions concernées.
- Notifications disponibles :
  - Alertes pour les véhicules endommagés.
  - Notifications de création de mots de passe pour les comptes des institutions.
  - Notifications sur la disponibilité de nouveaux véhicules.
