class User < ActiveRecord::Base

validates_presence_of :email, :fullname, :location, :password, message: ' e um campo obrigatorio que nao foi preenchido'
validates_confirmation_of :password, :on => :create, message: '  A confirmacao da senha esta errada, digite a senha certa'

has_many :contacts


has_many :enterprises
end


